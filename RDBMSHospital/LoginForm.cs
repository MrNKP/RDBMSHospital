using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDBMSHospital
{
    public partial class LoginForm : Form
    {
        LoginContext lc = new LoginContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usr, psw, rl;
            usr = usernameTextBox.Text;
            psw = passwordTextBox.Text;
            User locUser = lc.Users.Where(p => (p.username.Equals(usr)) && (p.password.Equals(psw))).FirstOrDefault();
            if (locUser != null)
            {
                rl = locUser.Role.role1;
                startForm frm = new startForm(usr, rl);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username/password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
