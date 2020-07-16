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
    public partial class Profile : Form
    {
        ServiceBRAdmin.BranchAdminServiceClient a = new ServiceBRAdmin.BranchAdminServiceClient();
        public Profile()
        {
            InitializeComponent();
            ServiceBRAdmin.BranchAdminData data = new ServiceBRAdmin.BranchAdminData();
            data = a.getSingle(UserInfo.id);
            if(data!=null)
            { 
            adminname.Text = data.Name;
            adminemail.Text = data.Email;
            adminpassword.Text = data.Password;
            admincontact.Text = data.Contact;
            admindob.Value = data.DOB;
            }
        }

        private void editprofilebtn_Click(object sender, EventArgs e)
        {
            ServiceBRAdmin.Branch_Admin admin = new ServiceBRAdmin.Branch_Admin();
            admin.Id = UserInfo.id;
            admin.Name = adminname.Text;
            admin.Email = adminemail.Text;
            admin.Contact = admincontact.Text;
            admin.DOB = admindob.Value;
            if(adminpassword.Text==confirmpassword.Text)
            {
                admin.Password = adminpassword.Text;
                ServiceBRAdmin.BranchAdminData data = new ServiceBRAdmin.BranchAdminData();
                data = a.updateBranchAdmin(admin);
                if (data != null)
                {
                    MessageBox.Show("Updated", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    confirmpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Error", "Info !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Confirm Password and Password not same","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          

        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInfo.id = 0;
            UserInfo.username = null;
            Form f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserName.Text = UserInfo.username;
            Email.Text = UserInfo.email;
        }

        private void profilebtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new Profile();
            f.ShowDialog();
        }

        private void managebr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form f = new ManageBranch();
            f.ShowDialog();
        }

        private void managead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form f = new ManageBiller();
            f.ShowDialog();
        }

        private void managest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form f = new ManageStock();
            f.ShowDialog();
        }

        private void managebil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form f = new ManageBills();
            f.ShowDialog();
        }

        private void ViewSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ViewSales().ShowDialog();
        }
    }
}
