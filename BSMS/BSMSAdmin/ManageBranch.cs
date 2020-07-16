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
    public partial class ManageBranch : Form
    {
        ServiceBRAdmin.BranchAdminServiceClient s;
        List<string> item=new List<string>();
        List<int> itemid=new List<int>();
        ServiceBranch.Branch B = new ServiceBranch.Branch();



        ServiceBranch.BranchServiceClient a = new ServiceBranch.BranchServiceClient();
        List<ServiceBranch.Branchdata> data = new List<ServiceBranch.Branchdata>();


        public ManageBranch()
        {
            InitializeComponent();
            s = new ServiceBRAdmin.BranchAdminServiceClient();
            itemid.Add(0);
            foreach(ServiceBRAdmin.BranchAdminData i in s.selectBranchAdmin().ToList())
            {
                item.Add(i.Name);
                itemid.Add(i.Id);
            }
            combobr_adminList.Items.Add("Location");
            editcomboadmin.Items.Add("Location");
           foreach(string i in item)
            {
                combobr_adminList.Items.Add(i);
                editcomboadmin.Items.Add(i);
            }
            AllBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            List.BringToFront();
           
        }

        private void ManageBranch_Load(object sender, EventArgs e)
        {
            Load_data();
            UserName.Text = UserInfo.username;
            Email.Text = UserInfo.email;
           
        }
        private void Load_data()
        {
            data = a.selectBranch().ToList();
            branchdata.DataSource = data;

           
        }

  

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r= CustomMessage.Show("Operation", "Select Edit or Delete", "Edit", "Delete", "Cancel");
            if (r == DialogResult.Yes)
            {
                DataGridViewRow row = branchdata.Rows[e.RowIndex];

                B.Id = Int32.Parse(row.Cells["Id"].Value.ToString());

                B.Br_Admin_ID = Int32.Parse(row.Cells["Br_Admin_ID"].Value.ToString());
                B.Location = row.Cells["Location"].Value.ToString();
                editlocationtxt.Text = B.Location;
                EditPanel.Show();
                List.Hide();
                AddPanel.Hide();
            }
            else if (r == DialogResult.No)
            {
                DataGridViewRow row = branchdata.Rows[e.RowIndex];
                ServiceBranch.BranchServiceClient sb = new ServiceBranch.BranchServiceClient();
             

                ServiceBranch.Branchdata data = new ServiceBranch.Branchdata();
                data = sb.deleteBranch(Int32.Parse(row.Cells["Id"].Value.ToString()));
                
               if(data!=null)
                { 
                    MessageBox.Show("Deleted successfully","Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Load_data();
                }

            }
            else
            {
               
            }
        }

        private void AllBranch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            AddBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            List.Show();
            EditPanel.Show();
            AddPanel.Show();
        }

        private void AddBranch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            AddBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            List.Hide();
            EditPanel.Hide();
            AddPanel.Show();
            
        }

        private void branchaddbtn_Click(object sender, EventArgs e)
        {
              
            if (!string.IsNullOrEmpty(txtlocation.Text) && combobr_adminList.SelectedIndex > 0)
            {
               
               int br_admin_id = itemid[combobr_adminList.SelectedIndex];
                ServiceBranch.BranchServiceClient c = new ServiceBranch.BranchServiceClient();
                ServiceBranch.Branch d = new ServiceBranch.Branch();
                d.Location = txtlocation.Text;
                d.Br_Admin_ID = br_admin_id;
                d = c.addBranch(d);
                if (d!= null && d.Id > 0)
                {
                    MessageBox.Show("Add Sucessfully", "Branch Added !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_data();
                    AddPanel.Hide();
                    EditPanel.Hide();
                    List.Show();
                }
                else
                {
                    MessageBox.Show("Fail", "Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Fill all Fields", " Info !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void editbranchbtn_Click(object sender, EventArgs e)
        {
            if (editlocationtxt.Text == String.Empty)
            {
                MessageBox.Show("Fill all Fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editcomboadmin.SelectedIndex > 0)
                {

                    B.Br_Admin_ID = itemid[editcomboadmin.SelectedIndex];
                }
                B.Location = editlocationtxt.Text;
                ServiceBranch.BranchServiceClient s = new ServiceBranch.BranchServiceClient();
                ServiceBranch.Branchdata data = new ServiceBranch.Branchdata();
                data = s.updateBranch(B);
                if (data != null)
                {
                    MessageBox.Show("Edit Successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_data();
                    AddPanel.Hide();
                    EditPanel.Hide();
                    List.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchBranch_TextChanged(object sender, EventArgs e)
        {
            List<ServiceBranch.Branchdata> searchdata = new List<ServiceBranch.Branchdata>();
            
           
          
            foreach(ServiceBranch.Branchdata i in data)
            {
                string d = i.Id + i.Location + i.Br_Admin_Name + i.Br_Admin_ID;
                if(d.ToLower().Contains(SearchBranch.Text.ToLower())==true)
                {
                   
                    searchdata.Add(i);
                }

            }
            branchdata.DataSource = searchdata;
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

        private void ViewSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ViewSales().ShowDialog();

        }
    }
}
