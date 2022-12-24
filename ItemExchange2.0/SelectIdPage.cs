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
    public partial class SelectIdPage : Form
    {
        public SelectIdPage()
        {
            InitializeComponent();

            this.Text = "请选择您的身份";
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserLoginPage ulp = new UserLoginPage();
            ulp.ShowDialog();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ManagerLoginPage mlp = new ManagerLoginPage();
            mlp.ShowDialog();
        }

    }
}
