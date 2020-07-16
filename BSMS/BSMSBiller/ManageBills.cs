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


        public ManageBills()
        {
            InitializeComponent();


            load_data();
            All.BringToFront();

        }

        public void load_data()
        {

            billdata = sb.selectBillperBranch(UserInfo.branch_id).ToList();
            List<ServiceBill.Billdata> data = new List<ServiceBill.Billdata>();
            foreach (ServiceBill.Billdata i in billdata)
            {
                if (i.Biller_ID == UserInfo.id)
                {
                    data.Add(i);
                }
            }
            billdata = data;
            branchBillsView.DataSource = billdata;


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
            saleproductview.DataSource = saledata;
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







        private void profilebtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Profile().ShowDialog();
        }

        private void ManageBills_Load(object sender, EventArgs e)
        {
            UserName.Text = UserInfo.username;
            Email.Text = UserInfo.email;
        }

        private void viewbills_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Createbill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new GenerateBill().ShowDialog();
        }
    }
}















