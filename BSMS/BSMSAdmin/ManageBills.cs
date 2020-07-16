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
    public partial class ManageBills : Form
    {
        ServiceBill.BillServiceClient sb = new ServiceBill.BillServiceClient();
        ServiceBill.Bill bill = new ServiceBill.Bill();
        List<ServiceBill.Billdata> billdata = new List<ServiceBill.Billdata>();
        List<ServiceSale.SalesData> saledata = new List<ServiceSale.SalesData>();

        ServiceBranch.BranchServiceClient branch = new ServiceBranch.BranchServiceClient();
        List<string> branchName = new List<string>();
        List<int> branchid = new List<int>();
        public ManageBills()
        {
            InitializeComponent();
            branchName.Add("Branch");
            branchid.Add(0);
            foreach(ServiceBranch.Branchdata i in branch.selectBranch())
            {
                branchid.Add(i.Id);
                branchName.Add(i.Location);
            }
            foreach(string i in branchName)
            {
                selectbranch.Items.Add(i);
            }
            load_data();
            All.BringToFront();

        }

        public void load_data()
        {
            if (branchid.Count>1)
            {
                billdata = sb.selectBillperBranch(branchid[1]).ToList();
                branchBillsView.DataSource = billdata;
            }

        }

        private void AllBils_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All.BringToFront();
        }


        private void brallBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = branchBillsView.Rows[e.RowIndex];

            int Billid = Int32.Parse(row.Cells["Id"].Value.ToString());
            ServiceSale.SalesServiceClient sp = new ServiceSale.SalesServiceClient();
            saledata = sp.getSale(Billid).ToList();
            saleproductview.DataSource =saledata;
            Products.BringToFront();
        }

        private void SearchBills_TextChanged(object sender, EventArgs e)
        {
            List<ServiceBill.Billdata> searchdata = new List<ServiceBill.Billdata>();

            foreach (ServiceBill.Billdata i in billdata)
            {
                string d = i.Id + i.Biller_ID + i.Branch_ID + i.Customer_Name + i.Customer_Contact + i.Amount + i.Date + i.Payment_Mode + i.Location;
                if (d.ToLower().Contains(SearchBills.Text.ToLower()) == true)
                {
                    searchdata.Add(i);
                }

            }
            branchBillsView.DataSource = searchdata;
        }

        private void SearchProducts_TextChanged(object sender, EventArgs e)
        {
            List<ServiceSale.SalesData> searchdata = new List<ServiceSale.SalesData>();

            foreach (ServiceSale.SalesData i in saledata)
            {
                string d = i.Id + i.Bill_ID + i.Name + i.Total + i.Quantity + i.Stock_ID;
                if (d.ToLower().Contains(SearchProducts.Text.ToLower()) == true)
                {
                    
                    searchdata.Add(i);
                }

            }
            saleproductview.DataSource = searchdata;
        }

        private void ManageBills_Load(object sender, EventArgs e)
        {
            UserName.Text = UserInfo.username;
            Email.Text = UserInfo.email;
        }

        private void Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            Form f = new ManageBranchAdmin();
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

        private void selectbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectbranch.SelectedIndex>0)
            {
               billdata = sb.selectBillperBranch(branchid[selectbranch.SelectedIndex]).ToList();
                branchBillsView.DataSource = billdata;
            }
        }
    }
}















