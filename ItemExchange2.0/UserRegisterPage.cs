using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace ItemExchange2._0
{
    public partial class UserRegisterPage : Form
    {
        public UserRegisterPage()
        {
            InitializeComponent();

            this.Text = "用户注册";
        }

        private void RegisterConfirmButton_Click(object sender, EventArgs e)
        {
            if (this.UserNameTextBox.Text == ""
                || this.UserAddressTextBox.Text == ""
                || this.UserPhoneNumberTextBox.Text == ""
                || this.UserPasswordTextBox.Text == "")
            {
                MessageBox.Show("请完成信息填写！");
            }
            else
            {
                string jsonSTRING = File.ReadAllText("tmplist.json");
                List<User> tmpList = JsonConvert.DeserializeObject<List<User>>(jsonSTRING);

                if (tmpList == null)
                {
                    tmpList = new List<User>();
                }

                User tmp = new User(this.UserNameTextBox.Text, this.UserPasswordTextBox.Text, this.UserAddressTextBox.Text, this.UserPhoneNumberTextBox.Text);
                tmpList.Add(tmp);

                string data = JsonConvert.SerializeObject(tmpList);
                File.WriteAllText("tmplist.json", data);

                MessageBox.Show("已成功提交注册申请，审核员将于1h内审批您的申请");
            }
        }
    }
}
