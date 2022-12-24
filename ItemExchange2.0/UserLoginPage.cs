using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace ItemExchange2._0
{
    public partial class UserLoginPage : Form
    {
        public UserLoginPage()
        {
            InitializeComponent();

            this.Text = "用户登录";
        }

        private void UserLogInButton_Click(object sender, EventArgs e)
        {
            if (this.UserNameTextBox.Text == "" || this.UserPasswordTextBox.Text == "")
            {
                MessageBox.Show("请完成输入！");
            }
            else 
            {
                User tmp = new User(this.UserNameTextBox.Text, this.UserPasswordTextBox.Text);

                //与已有的用户数据库进行匹配
                string jsonSTRING = File.ReadAllText("userlist.json");
                List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonSTRING);

                if (userList == null)
                {
                    userList = new List<User>();
                }

                if (userList.Contains(tmp))
                {
                    MessageBox.Show("登陆成功！");
                    User IdProcessing = userList.Find(t=>t.name==tmp.name&&t.password==tmp.password);
                    ItemPage up = new ItemPage();
                    up.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("登陆失败！用户名或密码输入可能有误");
                }
            }
        }

        private void UserRegisterButton_Click(object sender, EventArgs e)
        {
            UserRegisterPage urp = new UserRegisterPage();

            urp.ShowDialog();
        }
    }
}
