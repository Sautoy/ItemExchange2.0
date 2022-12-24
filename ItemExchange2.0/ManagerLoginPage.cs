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
    public partial class ManagerLoginPage : Form
    {
        public ManagerLoginPage()
        {
            InitializeComponent();

            this.Text = "管理员登录";
        }

        private void ManagerPasswordButton_Click(object sender, EventArgs e)
        {
            if (this.ManagerPasswordtextBox.Text == "2") {
                MessageBox.Show("登陆成功！");
                ManagerPage mp = new ManagerPage();
                mp.ShowDialog();
            }
            else
                MessageBox.Show("登陆失败！");
        }
    }
}
