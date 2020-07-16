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
    public partial class ManageBranchAdmin : Form
    {
        ServiceBRAdmin.BranchAdminServiceClient s = new ServiceBRAdmin.BranchAdminServiceClient();
        ServiceBRAdmin.Branch_Admin bradmin = new ServiceBRAdmin.Branch_Admin();
        List<ServiceBRAdmin.BranchAdminData> brAdmins = new List<ServiceBRAdmin.BranchAdminData>();

        public ManageBranchAdmin()
        {
            InitializeComponent();
            load_data();
            All.BringToFront();
        }

        public void load_data()
        {
            brAdmins = s.selectBranchAdmin().ToList();
            brAdmindata.DataSource = brAdmins;
        }

        private void brAdmindata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r = CustomMessage.Show("Operation", "Select Edit or Delete", "Edit", "Delete", "Cancel");
            if (r == DialogResult.Yes)
            {
                DataGridViewRow row = brAdmindata.Rows[e.RowIndex];

                bradmin.Id = Int32.Parse(row.Cells["Id"].Value.ToString());
                bradmin.Name = row.Cells["Name"].Value.ToString();
                bradmin.Contact = row.Cells["Contact"].Value.ToString();
                bradmin.DOB = (System.DateTime)row.Cells["DOB"].Value;
                bradmin.Email = row.Cells["Email"].Value.ToString();
                bradmin.Password = row.Cells["Password"].Value.ToString();

                editName.Text = bradmin.Name;
                editContact.Text = bradmin.Contact;
                editDOB.Value = bradmin.DOB;
                editEmail.Text = bradmin.Email;
                editPassword.Text = bradmin.Password;
                Edit.BringToFront();
            }
            else if (r == DialogResult.No)
            {
                DataGridViewRow row = brAdmindata.Rows[e.RowIndex];

              

                ServiceBRAdmin.BranchAdminData data = new ServiceBRAdmin.BranchAdminData();
                data = s.deleteBranchAdmin(Int32.Parse(row.Cells["Id"].Value.ToString()));

                if (data != null)
                {
                    MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                }

            }
            else
            {

            }
        }

        private void editbranchAdminbtn_Click(object sender, EventArgs e)
        {
            bradmin.Name = editName.Text;
            bradmin.Contact = editContact.Text;
            bradmin.DOB = editDOB.Value;
            bradmin.Email = editEmail.Text;
            bradmin.Password = editPassword.Text;

            ServiceBRAdmin.BranchAdminData data = new ServiceBRAdmin.BranchAdminData();
            data = s.updateBranchAdmin(bradmin);
            if (data != null)
            {
                MessageBox.Show("Edit Successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                All.BringToFront();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewBrAdminBtn_Click(object sender, EventArgs e)
        {
            if (BrAdminName.Text == String.Empty || Contact.Text == String.Empty || EmailId.Text == String.Empty || NewBrAdminpassword.Text == String.Empty)
            {
                MessageBox.Show("Fill all Fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bradmin.Name = BrAdminName.Text;
                bradmin.Contact = ContactNo.Text;
                bradmin.Email = EmailId.Text;
                bradmin.DOB = NewBrAdminDOB.Value;
                bradmin.Password = NewBrAdminpassword.Text;

                ServiceBRAdmin.Branch_Admin data = new ServiceBRAdmin.Branch_Admin();
                data = s.addBranchAdmin(bradmin);
                if (data != null)
                {
                    MessageBox.Show("Admin added successfully", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    All.BringToFront();
                }
                else
                {
                    MessageBox.Show("Try Again some thing wents wrong", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AllBrAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All.BringToFront();
        }

        private void NewBrAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add.BringToFront();
        }

        private void SearchBranchAdmin_TextChanged(object sender, EventArgs e)
        {
            List<ServiceBRAdmin.BranchAdminData> searchdata = new List<ServiceBRAdmin.BranchAdminData>();

            foreach (ServiceBRAdmin.BranchAdminData  i in brAdmins)
            {
                string d = i.Id + i.Name + i.Email + i.DOB + i.Contact;
                if (d.ToLower().Contains(SearchBranchAdmin.Text.ToLower()) == true)
                {
                    searchdata.Add(i);
                }

            }
            brAdmindata.DataSource = searchdata;
        }

        private void ManageBranchAdmin_Load(object sender, EventArgs e)
        {
            UserName.Text = UserInfo.username;
            Email.Text = UserInfo.email;
        }

        private void Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Profile().ShowDialog();
        }

        private void managebr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ManageBranch().ShowDialog();
        }

        private void managead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ManageBranchAdmin().ShowDialog();
        }

        private void managest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ManageStock().ShowDialog();
        }

        private void managebil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ManageBills().ShowDialog();
        }
    }
}
