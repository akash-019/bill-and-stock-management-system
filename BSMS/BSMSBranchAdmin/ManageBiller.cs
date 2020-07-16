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
    public partial class ManageBiller : Form
    {
        ServiceBiller.BillerServiceClient s = new ServiceBiller.BillerServiceClient();
        List<ServiceBiller.Billerdata> brBillers = new List<ServiceBiller.Billerdata>();
        ServiceBranch.BranchServiceClient br = new ServiceBranch.BranchServiceClient();
        ServiceBiller.Biller biller = new ServiceBiller.Biller();
        List<int> br_Id = new List<int>();
        List<string> br_Name = new List<string>();
        public ManageBiller()
        {
            InitializeComponent();
            br_Id.Add(0);
            br_Name.Add("branch");
            foreach (ServiceBranch.Branchdata i in br.selectBranchperAdmin(UserInfo.id))
            {
                br_Id.Add(i.Id);
                br_Name.Add(i.Location);
            }
            foreach (string i in br_Name)
            {
                selectbranch.Items.Add(i);
                addcombobranch.Items.Add(i);
                editcombobranch.Items.Add(i);
            }
            All.BringToFront();
        }



        private void brAdmindata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r = CustomMessage.Show("Operation", "Select Edit or Delete", "Edit", "Delete", "Cancel");
            if (r == DialogResult.Yes)
            {
                DataGridViewRow row = brBillderdata.Rows[e.RowIndex];

                biller.Id = Int32.Parse(row.Cells["Id"].Value.ToString());
                biller.Branch_ID = Int32.Parse(row.Cells["Branch_ID"].Value.ToString());
                biller.Contact = row.Cells["Contact"].Value.ToString();
                biller.DOB = (System.DateTime)row.Cells["DOB"].Value;
                biller.Email = row.Cells["Email"].Value.ToString();
                biller.Password = row.Cells["Password"].Value.ToString();

                editcombobranch.SelectedIndex = br_Id.IndexOf(biller.Branch_ID);
                editContact.Text = biller.Contact;
                editDOB.Value = biller.DOB;
                editEmail.Text = biller.Email;
                editPassword.Text = biller.Password;
                Edit.BringToFront();
            }
            else if (r == DialogResult.No)
            {
                DataGridViewRow row = brBillderdata.Rows[e.RowIndex];

                

                ServiceBiller.Billerdata data = new ServiceBiller.Billerdata();
                data = s.deleteBiller(Int32.Parse(row.Cells["Id"].Value.ToString()));

                if (data != null)
                {
                    MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    brBillderdata.Refresh();
                }

            }
            else
            {

            }
        }

        private void editbranchAdminbtn_Click(object sender, EventArgs e)
        {
            if (editContact.Text == String.Empty || editEmail.Text == String.Empty || editPassword.Text == String.Empty)
            {
                MessageBox.Show("Fill all Fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                biller.Branch_ID = br_Id[editcombobranch.SelectedIndex];
                biller.Contact = editContact.Text;
                biller.DOB = editDOB.Value;
                biller.Email = editEmail.Text;
                biller.Password = editPassword.Text;

                ServiceBiller.Billerdata data = new ServiceBiller.Billerdata();
                data = s.updateBiller(biller);
                if (data != null)
                {
                    MessageBox.Show("Edit Successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    brBillderdata.Refresh();
                    All.BringToFront();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NewBrAdminBtn_Click(object sender, EventArgs e)
        {
            if (ContactNo.Text == String.Empty || EmailId.Text == String.Empty || NewBrAdminpassword.Text == String.Empty)
            {
                MessageBox.Show("Fill all Fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                biller.Branch_ID = br_Id[addcombobranch.SelectedIndex];
                biller.Contact = ContactNo.Text;
                biller.Email = EmailId.Text;
                biller.DOB = NewBrAdminDOB.Value;
                biller.Password = NewBrAdminpassword.Text;

                ServiceBiller.Biller data = new ServiceBiller.Biller();
                data = s.addBiller(biller);
                if (data != null)
                {
                    MessageBox.Show("admin added successfully", "info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    brBillderdata.Refresh();
                    All.BringToFront();
                }
                else
                {
                    MessageBox.Show("try again some thing wents wrong", "info!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            List<ServiceBiller.Billerdata> searchdata = new List<ServiceBiller.Billerdata>();

            foreach (ServiceBiller.Billerdata  i in brBillers)
            {
                string d = i.Id + i.Branch_ID + i.Contact + i.DOB + i.Email+i.Password;
                if (d.ToLower().Contains(SearchBranchAdmin.Text.ToLower()) == true)
                {
                    searchdata.Add(i);
                }

            }
            brBillderdata.DataSource = searchdata;
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
            new ManageBiller().ShowDialog();
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

        private void viewsale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ViewSales().ShowDialog();
        }

        private void selectbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectbranch.SelectedIndex>0)
            {
                brBillers = s.selectBillerperBranch(br_Id[selectbranch.SelectedIndex]).ToList();
                brBillderdata.DataSource = brBillers;
            }
        }
    }
}
