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
    public partial class TagPage : UIForm
    {
        public TagPage()
        {
            InitializeComponent();

            this.Text = "标签管理";

            string jsonSTRING = File.ReadAllText("taglist.json");
            List<Tag> tagList = JsonConvert.DeserializeObject<List<Tag>>(jsonSTRING);
 
            if (tagList == null)
            {
                tagList = new List<Tag>();
            }

            // 显示到表格中
            TagGridView.Rows.Clear();
            foreach (Tag tag in tagList)
            {
                object[] row =
                   {
                        tag.name,
                        tag.property,
                    };

                // 关联数据，便于保存
                int rowIndex = TagGridView.Rows.Add(row);
                TagGridView.Rows[rowIndex].Tag = tag;
            }
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            TagEdit ta = new TagEdit();
            if (ta.ShowDialog(this) == DialogResult.OK)
            {
                Tag tag = ta.GetValue();
                object[] row =
                   {
                        tag.name,
                        tag.property,
                    };
                int rowIndex = TagGridView.Rows.Add(row);
                TagGridView.Rows[rowIndex].Tag = tag;
            }
        }

        private void ModifyTag_Click(object sender, EventArgs e)
        {
            // 获取选中行对应的tag信息，将其显示在编辑对话框中
            int rowIndex = TagGridView.SelectedRows[0].Index;
            Tag tag = (Tag)TagGridView.Rows[rowIndex].Tag;
            TagEdit te = new TagEdit();
            te.InitValue(tag);

            if (te.ShowDialog(this) == DialogResult.OK)
            {
                Tag newtag = te.GetValue();
                TagGridView.Rows[rowIndex].Tag = newtag;
                TagGridView[0, rowIndex].Value = newtag.name;
                TagGridView[1, rowIndex].Value = newtag.property;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tag_SaveData();
            MessageBox.Show("保存成功！");
        }

        private void tag_SaveData()
        {
            List<Tag> tagList = new List<Tag>();
            for (int i = 0; i < TagGridView.Rows.Count; i++)
            {
                Tag tag = (Tag)TagGridView.Rows[i].Tag;
                tagList.Add(tag);
            }

            string data = JsonConvert.SerializeObject(tagList);
            File.WriteAllText("taglist.json", data);
        }

        //鼠标操作右键菜单
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

        private void TagGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(TagGridView, e.Location);
                // GetCellAt: 根据点击的位置，判断点中了哪个单元格
                Point p = GetCellAt(TagGridView, e.Location);
                int rowIndex = p.X;

                // 设置选中状态
                TagGridView.ClearSelection();
                if (rowIndex >= 0)
                    TagGridView.Rows[rowIndex].Selected = true;

                // 设置菜单项的状态
                ModifyTag.Enabled = (rowIndex >= 0);
            }
        }


    }
}
