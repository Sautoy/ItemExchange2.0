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
    public partial class ItemEdit : Form
    {
        public ItemEdit()
        {
            InitializeComponent();

            this.Text = "物品信息编辑窗口";
        }

        //初始化编辑界面内容
        public void InitValue()
        {
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

            ItemNameTextBox.Enabled = false;
            PropertyTextBox.Enabled = false;
            AddressTextBox.Enabled = false;
            PhoneTextBox.Enabled = false;
            EmailTextBox.Enabled = false;

        }

        //根据填入的信息生成Item对象
        public Item GetValue()
        {
            Item item = new Item();

            item.tag = TagComboBox.Text;
            item.name = ItemNameTextBox.Text;
            item.property = PropertyTextBox.Text;
            item.address = AddressTextBox.Text;
            item.ownerPhone = PhoneTextBox.Text;
            item.ownerEmail = EmailTextBox.Text;

            return item;
        }

        //物品信息编辑设置：只有物品类别选定后，才能继续填写其他字段
        private void TagComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ItemNameTextBox.Enabled = true;
            PropertyTextBox.Enabled = true;
            AddressTextBox.Enabled = true;
            PhoneTextBox.Enabled = true;
            EmailTextBox.Enabled = true;

            //根据选定的Tag提供提示
            string jsonSTRING = File.ReadAllText("taglist.json");
            List<Tag> tagList = JsonConvert.DeserializeObject<List<Tag>>(jsonSTRING);

            if (tagList == null)
            {
                tagList = new List<Tag>();
            }

            Tag tag=tagList.Find(t=>t.name==(String)TagComboBox.SelectedItem);
            PropertyTextBox.Watermark = tag.property;
        }

        //确认添加物品
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Item item = GetValue();
            if (item == null)
                return;

            this.DialogResult = DialogResult.OK;
        }
    }
}
