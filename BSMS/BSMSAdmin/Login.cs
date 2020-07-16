using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSMSAdmin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

     

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            ServiceLogin.LoginServiceClient c = new ServiceLogin.LoginServiceClient();
            ServiceLogin.Admin a = c.Admin_login(Username.Text, Password.Text);
            if (Username.Text != null && Password != null)
            {
                if (a != null)
                {
                    UserInfo.id = a.Id;
                    UserInfo.username = a.UserName;
                    UserInfo.email = a.Email;
                    Form nextForm = new Profile();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Failed to Login Try Again", "Error Fail to Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }
    }
}
