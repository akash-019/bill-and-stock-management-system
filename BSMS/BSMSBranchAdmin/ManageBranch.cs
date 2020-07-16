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
        
        ServiceBranch.Branch B = new ServiceBranch.Branch();



        ServiceBranch.BranchServiceClient a = new ServiceBranch.BranchServiceClient();
        List<ServiceBranch.Branchdata> data = new List<ServiceBranch.Branchdata>();


        public ManageBranch()
        {
            InitializeComponent();
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
            data = a.selectBranchperAdmin(UserInfo.id).ToList();
            branchdata.DataSource = data;

           
        }

  

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you want to Edit Info !", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                DataGridViewRow row = branchdata.Rows[e.RowIndex];

                B.Id = Int32.Parse(row.Cells["Id"].Value.ToString());

                B.Br_Admin_ID = Int32.Parse(row.Cells["Br_Admin_ID"].Value.ToString());
                B.Location = row.Cells["Location"].Value.ToString();
                editlocationtxt.Text = B.Location;
                EditPanel.Show();
                List.Hide();
               
            }
       
        }

        private void AllBranch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllBranch.BringToFront();
        }

      

     

        private void editbranchbtn_Click(object sender, EventArgs e)
        {
            B.Br_Admin_ID = UserInfo.id;
            B.Location = editlocationtxt.Text;
            ServiceBranch.BranchServiceClient s = new ServiceBranch.BranchServiceClient();
            ServiceBranch.Branchdata data = new ServiceBranch.Branchdata();
            data = s.updateBranch(B);
            if(data!=null)
            {
                MessageBox.Show("Edit Successfully","Edit",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Load_data();
                List.Show();
            
                EditPanel.Hide();
            }else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ViewSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ViewSales().ShowDialog();

        }
    }
}
