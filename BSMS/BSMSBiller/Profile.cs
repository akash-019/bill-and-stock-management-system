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
        ServiceBiller.BillerServiceClient a = new ServiceBiller.BillerServiceClient();
        ServiceBiller.Billerdata data = new ServiceBiller.Billerdata();
        public Profile()
        {
            InitializeComponent();
            
            data = a.getSingle(UserInfo.id);
            if(data!=null)
            { 
          
            billeremail.Text = data.Email;
            billerpassword.Text = data.Password;
            contactcontact.Text = data.Contact;
            billlerdob.Value = data.DOB;
            }
        }

        private void editprofilebtn_Click(object sender, EventArgs e)
        {
            ServiceBiller.Biller biller = new ServiceBiller.Biller();
            biller.Id = UserInfo.id;
            biller.Branch_ID = UserInfo.branch_id;
            biller.Email = billeremail.Text;
            biller.Contact = contactcontact.Text;
            biller.DOB = billlerdob.Value;
            if(billerpassword.Text==confirmpassword.Text)
            {
                biller.Password = billerpassword.Text;
                ServiceBiller.Billerdata data = new ServiceBiller.Billerdata();
                 data = a.updateBiller(biller);
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

        private void viewbills_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ManageBills().ShowDialog();
        }

        private void Createbill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new GenerateBill().ShowDialog();
        }

       
    }

      
    
}
