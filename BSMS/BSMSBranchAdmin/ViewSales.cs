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
    public partial class ViewSales : Form
    {
        ServiceSale.SalesServiceClient s = new ServiceSale.SalesServiceClient();
         List<ServiceSale.SalesData> sdata = new List<ServiceSale.SalesData>();
        List<string> br_Name = new List<string>();
        List<int>  br_Id= new List<int>();
        ServiceBranch.BranchServiceClient br = new ServiceBranch.BranchServiceClient();

        public ViewSales()
        {
            InitializeComponent();
           
            br_Id.Add(0);
            br_Name.Add("Branch");
            foreach(ServiceBranch.Branchdata i in br.selectBranchperAdmin(UserInfo.id))
            {
                br_Id.Add(i.Id);
                br_Name.Add(i.Location);
            }
            foreach(string i in br_Name)
            {
                selectbranch.Items.Add(i);
            }
          
          
        }
      
      

        private void ViewSales_Load(object sender, EventArgs e)
        {
            this.UserName.Text = UserInfo.username;
            this.Email.Text = UserInfo.email;
        }

        private void SearchSale_TextChanged(object sender, EventArgs e)
        {
            List<ServiceSale.SalesData> data = new List<ServiceSale.SalesData>();
            foreach(ServiceSale.SalesData i in sdata)
            {
                string d =i.Bill_ID + i.Name + i.Quantity + i.Quantity + i.Total+i.Id;
                if(d.ToLower().Contains(SearchSale.Text.ToLower())==true)
                {
                    data.Add(i);
                }
            }
            saledata.DataSource = data;
        }

        private void profilebtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Profile().ShowDialog();
        }

        private void managebr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Hide();
            new ManageBranch().ShowDialog();
        }

        private void managead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Hide();
            new ManageBiller().ShowDialog();
        }

        private void managest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Hide();
            new ManageStock().ShowDialog();
        }

        private void managebil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Hide();
            new ManageBills().ShowDialog();
        }

        private void ViewSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Hide();
            new ViewSales().ShowDialog();
        }

        private void selectbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectbranch.SelectedIndex>0)
            {
                sdata = s.selectSaleperBranch(br_Id[selectbranch.SelectedIndex]).ToList();
                saledata.DataSource = sdata;
            }
          
        }
    }
}
