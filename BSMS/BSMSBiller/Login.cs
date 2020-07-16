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
            ServiceLogin.Billerdata a = c.Biller_login(Username.Text, Password.Text);
            if (Username.Text != null && Password != null)
            {
                if (a != null)
                {
                    UserInfo.id = a.Id;
                    UserInfo.username = a.Id+"";
                    UserInfo.email = a.Email;
                    UserInfo.branch_id = a.Branch_ID;
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
