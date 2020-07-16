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
    public partial class GenerateBill : Form
    {
        ServiceStock.StockServiceClient s = new ServiceStock.StockServiceClient();
        ServiceSale.SalesServiceClient ss = new ServiceSale.SalesServiceClient();
        ServiceBill.BillServiceClient b = new ServiceBill.BillServiceClient();
        List<ServiceStock.StockData> sdata = new List<ServiceStock.StockData>();
        List<ServiceSale.Sale> saledata = new List<ServiceSale.Sale>();
        List<billgrid> billsitem = new List<billgrid>();
       
        List<int> stockid = new List<int>();
        List<string> stockName = new List<string>();
        public GenerateBill()
        {
           
            InitializeComponent();
            load_data();
            stockid.Add(0);
            stockName.Add("Select");
            foreach(ServiceStock.StockData i in sdata)
            {
                stockid.Add(i.Id);
                stockName.Add(i.Name);
            }
            for(int i=0;i<stockid.Count;i++)
            {
                brproductlist.Items.Add(stockName[i]+""+stockid[i]);
            }
        }
        public void load_sale()
        {
            var bind = new System.Windows.Forms.BindingSource { DataSource = billsitem };
            billitemgrid.DataSource = bind;

        }
        public void load_data()
        {
            sdata = s.selectStockperBranch(UserInfo.branch_id).ToList();
            List<ServiceStock.StockData> tmp = new List<ServiceStock.StockData>();
               
            foreach(ServiceStock.StockData i in sdata)
            {
                
                if(i.Available>0)
                {
                    tmp.Add(i);
                }
            }
           
            sdata = tmp;

        }

        private void GenerateBill_Load(object sender, EventArgs e)
        {
            UserName.Text = UserInfo.username;
            Email.Text = UserInfo.email;
            billitemgrid.AllowUserToAddRows = false;
        }

        private void brproductlist_SelectedIndexChanged(object sender, EventArgs e)
        { ServiceStock.StockData s = sdata.FirstOrDefault(m => m.Id == stockid[brproductlist.SelectedIndex]);
            if (s != null)
            {
                Quntityindicator.Text = "< " + s.Available;
            }
            else
            {
                Quntityindicator.Text = "00";
            }
        }

        private void addtobill_Click(object sender, EventArgs e)
        {

            ServiceStock.StockData s = new ServiceStock.StockData();
            s = sdata.FirstOrDefault(m => m.Id == stockid[brproductlist.SelectedIndex]);
            ServiceSale.Sale row = new ServiceSale.Sale();
            row.Quantity = Int32.Parse(productquntity.Text);
            row.Stock_ID = stockid[brproductlist.SelectedIndex];
            row.Total = row.Quantity * s.Price;
            saledata.Add(row);
            billgrid b = new billgrid();
            b.Name = s.Name;
            b.Quantity = row.Quantity;
            b.Stockid = row.Stock_ID;
            b.Price = s.Price;
            b.Total = (int)row.Total;
            billsitem.Add(b);

            load_sale();
        }

        private void billitemgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = billitemgrid.Rows[e.RowIndex];
            if (DialogResult.Yes == MessageBox.Show("Are you want to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                billgrid b = billsitem.FirstOrDefault(m => m.Stockid == Int32.Parse(r.Cells["Stockid"].Value.ToString()) && m.Quantity == Int32.Parse(r.Cells["Quantity"].Value.ToString()));
                billsitem.Remove(b);
                ServiceSale.Sale s = new ServiceSale.Sale();
                s = saledata.FirstOrDefault(m => m.Stock_ID == b.Stockid && m.Quantity == b.Quantity);
                saledata.Remove(s);
                load_sale();
            }
        }

        private void billcancelbtn_Click(object sender, EventArgs e)
        {
            billitemgrid.DataSource = null;
            productquntity.Text = "";
            customercontact.Text = "";
            customername.Text = "";
        }

        private void generatebillbtn_Click(object sender, EventArgs e)
        {
            ServiceBill.Bill bill = new ServiceBill.Bill();
            int amount = 0;
            foreach(ServiceSale.Sale i in saledata)
            {
                amount = amount +(int)i.Total;
            }
            if (customercontact.Text == String.Empty || customername.Text == String.Empty)
            {
                MessageBox.Show("Fill all Fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bill.Amount = amount;
                bill.Biller_ID = UserInfo.id;
                bill.Branch_ID = UserInfo.branch_id;
                bill.Customer_Contact = customercontact.Text;
                bill.Customer_Name = customername.Text;
                bill.Date = billldate.Value;
                bill.Payment_Mode = paymode.SelectedItem.ToString();
                ServiceBill.Bill addedbill = b.addBill(bill);
                if (addedbill != null)
                {
                    foreach (ServiceSale.Sale i in saledata)
                    {
                        i.Bill_ID = addedbill.Id;
                    }
                    List<ServiceSale.SalesData> addsale = ss.addSale(saledata.ToArray()).ToList();
                    if (addsale != null)
                    {
                        MessageBox.Show("Bill added Successfully", "added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void profilebtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Profile().ShowDialog();
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
