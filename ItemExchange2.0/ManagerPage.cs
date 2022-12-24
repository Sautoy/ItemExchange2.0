using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.IO;
using Newtonsoft.Json;

namespace ItemExchange2._0
{
    public partial class ManagerPage : UIForm
    {
        public ManagerPage()
        {
            InitializeComponent();

            this.Text = "管理员界面";

            //导入申请数据
            string jsonSTRING = File.ReadAllText("tmplist.json");
            List<User> tmpList = JsonConvert.DeserializeObject<List<User>>(jsonSTRING);
            if (tmpList == null) {
                tmpList = new List<User>();
            }

            //显示到表单上并进行数据关联
            foreach (User user in tmpList)
            {
                object[] row=
                    {
                        user.name,
                        user.address,
                        user.phoneNumber,
                        user.password,
                    };

                int rowIndex = tmpGridView.Rows.Add(row);
                tmpGridView.Rows[rowIndex].Tag = user; 
            }
        }

        //通过申请
        private void PassStrip_Click(object sender, EventArgs e)
        {
            //打开正式用户名单
            string jsonSTRING = File.ReadAllText("userlist.json");
            List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonSTRING);

            if (userList == null) 
            {
                userList = new List<User>();
            }

            //加入处理完成后清除记录
            foreach (DataGridViewRow row in tmpGridView.SelectedRows)
            {
                User user = (User)tmpGridView.Rows[row.Index].Tag;
                userList.Add(user);
                tmpGridView.Rows.Remove(row);
            }

            string data = JsonConvert.SerializeObject(userList);
            File.WriteAllText("userlist.json", data);

            tmp_SaveData();

        }

        //拒绝申请
        private void RejectionStrip_Click(object sender, EventArgs e)
        {

            //拒绝申请即不载入正式的用户名单中，直接从tmplist中清除记录即可
            foreach (DataGridViewRow row in tmpGridView.SelectedRows)
            {
                tmpGridView.Rows.Remove(row);
            }

            tmp_SaveData();
        }

        // 根据鼠标点击的位置，判断该位置所在的单位格的索引
        private void tmpGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(tmpGridView, e.Location);
                // GetCellAt: 根据点击的位置，判断点中了哪个单元格
                Point p = GetCellAt(tmpGridView, e.Location);
            int rowIndex = p.X;

            // 设置选中状态
            tmpGridView.ClearSelection();
            if (rowIndex >= 0)
                tmpGridView.Rows[rowIndex].Selected = true;

            // 设置菜单项的状态
            Pass.Enabled = (rowIndex >= 0);
            Reject.Enabled = (rowIndex >= 0);
        }
    }
        
        public static Point GetCellAt(DataGridView grid, Point location)
        {
            int row = -1, col = -1;

            // 一共显示的行数: DisplayedRowCount()
            // 第一个显示的行： FirstDisplayedScrollingRowIndex
            // 某行的显示区域:  GetRowDisplayRectangle()
            for (int i = grid.FirstDisplayedScrollingRowIndex;
                i < grid.FirstDisplayedScrollingRowIndex + grid.DisplayedRowCount(true);
                i++)
            {
                Rectangle rect = grid.GetRowDisplayRectangle(i, true);
                if (location.Y > rect.Top && location.Y < rect.Bottom)
                {
                    row = i;
                    break;
                }
            }

            for (int k = grid.FirstDisplayedScrollingColumnIndex;
                k < grid.FirstDisplayedScrollingColumnIndex + grid.DisplayedColumnCount(true);
                k++)
            {
                Rectangle rect = grid.GetColumnDisplayRectangle(k, true);
                if (location.X > rect.Left && location.X < rect.Right)
                {
                    col = k;
                    break;
                }
            }

            return new Point(row, col);
        }

        //将表格中的数据保存到tmpList中
        private void tmp_SaveData()
        {
            List<User> tmpList = new List<User>();
            for (int i = 0; i < tmpGridView.Rows.Count; i++)
            {
                User user = (User) tmpGridView.Rows[i].Tag;
                tmpList.Add(user);
            }

            string data = JsonConvert.SerializeObject(tmpList);
            File.WriteAllText("tmplist.json", data);
        }
        
        //转移到物品标签管理界面
        private void TagManageButton_Click(object sender, EventArgs e)
        {
            TagPage tp = new TagPage();
            tp.ShowDialog();
        }
    }
}
