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
    public partial class ItemPage : UIForm
    {
        public ItemPage()
        {
            InitializeComponent();

            this.Text = "用户使用界面" ;

            //导入搜索框部分的标签选择
            string tag_jsonSTRING = File.ReadAllText("taglist.json");
            List<Tag> tagList = JsonConvert.DeserializeObject<List<Tag>>(tag_jsonSTRING);
            if (tagList == null)
            {
                tagList = new List<Tag>();
            }

            foreach (Tag type in tagList)
            {
                TagComboBox.Items.Add(type.name);
            }

            SearchItemName.Enabled = false;
            SearchProperty.Enabled = false;

            //导入物品数据
            string item_jsonSTRING2 = File.ReadAllText("itemlist.json");
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(item_jsonSTRING2);
            if (itemList == null)
            {
                itemList = new List<Item>();
            }

            foreach (Item item in itemList)
            {
                object[] row =
                    {
                        item.tag,
                        item.name,
                        item.property,
                        item.address,
                        item.ownerPhone,
                        item.ownerEmail,
                    };

                // 关联数据
                int rowIndex = ItemGridView.Rows.Add(row);
                ItemGridView.Rows[rowIndex].Tag = item;
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            ItemEdit ie = new ItemEdit();
            ie.InitValue();
            if (ie.ShowDialog(this) == DialogResult.OK)
            {
                Item item = ie.GetValue();
                object[] row =
                   {
                        item.tag,
                        item.name,
                        item.property,
                        item.address,
                        item.ownerPhone,
                        item.ownerEmail,
                    };
                int rowIndex = ItemGridView.Rows.Add(row);
                ItemGridView.Rows[rowIndex].Tag = item;
            }

            item_SaveData();
        }

        private void DelItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ItemGridView.SelectedRows)
            {
                ItemGridView.Rows.Remove(row);
            }

            item_SaveData();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //导入物品数据
            string item_jsonSTRING2 = File.ReadAllText("itemlist.json");
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(item_jsonSTRING2);
            if (itemList == null)
            {
                itemList = new List<Item>();
            }

            //从选择框中获得类别信息，进行第一轮搜索
            string tag = (String)TagComboBox.SelectedItem;
            List<Item> anslist=itemList.FindAll(t => t.tag == tag);

            //如果用户填写了物品名称，进行第二轮搜索
            if (anslist!=null && SearchItemName.Text!="") {
                string itemName = SearchItemName.Text;
                List<Item> list = anslist.FindAll(t => t.name == itemName);
                anslist = list;
            }

            //如果用户填写了物品说明，进行第三轮搜索
            if (anslist!=null&&SearchProperty.Text != "")
            {
                string property = SearchProperty.Text;
                List<Item> list = anslist.FindAll(t => t.property.Contains(property));
                anslist = list;
            }

            if (anslist == null)
                anslist = new List<Item>();

            //显示搜索结果，不进行保存操作
            ItemGridView.Rows.Clear();
            show(anslist);

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //导入物品数据
            string item_jsonSTRING2 = File.ReadAllText("itemlist.json");
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(item_jsonSTRING2);
            if (itemList == null)
            {
                itemList = new List<Item>();
            }

            ItemGridView.Rows.Clear();
            show(itemList);
        }

        //在表格中显示对应的物品列表信息
        public void show(List<Item> list)
        {
            foreach (Item item in list)
            {
                object[] row =
                    {
                        item.tag,
                        item.name,
                        item.property,
                        item.address,
                        item.ownerPhone,
                        item.ownerEmail,
                    };

                // 关联数据
                int rowIndex = ItemGridView.Rows.Add(row);
                ItemGridView.Rows[rowIndex].Tag = item;
            }
        }

        // 根据鼠标点击的位置，判断该位置所在的单位格的索引
        public static Point GetCellAt(DataGridView grid, Point location)
        {
            int row = -1, col = -1;

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

        private void ItemGridView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(ItemGridView, e.Location);
                // GetCellAt: 根据点击的位置，判断点中了哪个单元格
                Point p = GetCellAt(ItemGridView, e.Location);
                int rowIndex = p.X;

                // 设置选中状态
                ItemGridView.ClearSelection();
                if (rowIndex >= 0)
                    ItemGridView.Rows[rowIndex].Selected = true;

                // 设置菜单项的状态
                DelItem.Enabled = (rowIndex >= 0);
            }
        }

        //将表格中的数据重新保存到tmpList中
        private void item_SaveData()
        {
            List<Item> itemList = new List<Item>();
            for (int i = 0; i < ItemGridView.Rows.Count; i++)
            {
                Item item = (Item)ItemGridView.Rows[i].Tag;
                itemList.Add(item);
            }

            string data = JsonConvert.SerializeObject(itemList);
            File.WriteAllText("itemlist.json", data);
        }
        
        //搜索设置：只有物品类别选定后，才能输入其他字段进行搜索
        private void TagComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchItemName.Enabled = true;
            SearchProperty.Enabled = true;

            //根据选定的Tag提供提示
            string jsonSTRING = File.ReadAllText("taglist.json");
            List<Tag> tagList = JsonConvert.DeserializeObject<List<Tag>>(jsonSTRING);

            if (tagList == null)
            {
                tagList = new List<Tag>();
            }

            Tag tag = tagList.Find(t => t.name == (String)TagComboBox.SelectedItem);
            SearchProperty.Watermark = tag.property;
        }


    }
}
