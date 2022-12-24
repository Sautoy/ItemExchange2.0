using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemExchange2._0
{
    public partial class TagEdit : Form
    {

        public TagEdit()
        {
            InitializeComponent();

            this.Text = "类别添加窗口";
        }

        //确认添加或编辑
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Tag tag = GetValue();
            if (tag == null)
                return;

            this.DialogResult = DialogResult.OK;
        }

        //根据tag初始化编辑框的值
        public void InitValue(Tag tag)
        {
            TagNameTextBox.Text = tag.name;
            TagPropertyTextBox.Text = tag.property;
        }

        //根据填入的信息生成Tag对象
        public Tag GetValue()
        {
            Tag tag = new Tag();
            
            tag.name = TagNameTextBox.Text.Trim();
            tag.property = TagPropertyTextBox.Text.Trim();

            return tag;
        }

    }
}
