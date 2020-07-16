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
    public partial class ManageStock : Form
    {
        ServiceStock.StockServiceClient ss = new ServiceStock.StockServiceClient();
        ServiceStock.Stock s = new ServiceStock.Stock();
        ServiceBranch.BranchServiceClient br = new ServiceBranch.BranchServiceClient();
        List<ServiceStock.StockData> stockdata = new List<ServiceStock.StockData>();
        List<int> Br_Id = new List<int>();
        List<string> Br_Name = new List<string>();
        public ManageStock()
        {
            InitializeComponent();
            List<ServiceBranch.Branchdata> blist = new List<ServiceBranch.Branchdata>();
            blist = br.selectBranch().ToList();
            Br_Id.Add(0);
            Br_Name.Add("Select");

            foreach(ServiceBranch.Branchdata i in blist)
            {
                Br_Id.Add(i.Id);
                Br_Name.Add(i.Location);
            }

            foreach(string i in Br_Name)
            {
                BranchList.Items.Add(i);
                editBranchList.Items.Add(i);
                selectbranch.Items.Add(i);
            }

            load_data();
            All.BringToFront();
        }
        public void load_data()
        {   if (Br_Id.Count>1)
            {
                stockdata = ss.selectStockperBranch(Br_Id[1]).ToList();
                brStockdata.DataSource = stockdata;
            }
        }

  

        private void NewStockbtn_Click(object sender, EventArgs e)
        {
            if (StockQuntity.Text == String.Empty || StockPrice.Text == String.Empty)
            {
                MessageBox.Show("Fill all Fields", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ServiceStock.Stock s = new ServiceStock.Stock();
                s.Name = StockName.Text;
                s.Quantity = Int32.Parse(StockQuntity.Text);
                s.Price = Int32.Parse(StockPrice.Text);
                s.DOM = StockDOM.Value;
                s.Available = s.Quantity;
                s.Branch_Id = Br_Id[BranchList.SelectedIndex];
                ServiceStock.Stock data = new ServiceStock.Stock();
                data = ss.addStock(s);
                if (data != null)
                {
                    MessageBox.Show("Stock added successfully", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    All.BringToFront();
                }
                else
                {
                    MessageBox.Show("Try Again some thing wents wrong", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AllStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All.BringToFront();
        }

        private void NewStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            s = null;
            Add.BringToFront();
        }

        private void editStockbtn_Click(object sender, EventArgs e)
        {

             s.Name= editName.Text ;
             s.Quantity=Int32.Parse(editQuntity.Text);
             s.Available= Int32.Parse(editAvailable.Text);
             s.Price = Int32.Parse(editPrice.Text);
             s.DOM = editDOM.Value;
             s.Branch_Id = Br_Id[editBranchList.SelectedIndex];
            ServiceStock.StockData data = new ServiceStock.StockData();
            data = ss.updateStock(s);
            if (data != null)
            {
                selectbranch.Text="";
                MessageBox.Show("Edit Successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                All.BringToFront();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brStockdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult r = CustomMessage.Show("Operation", "Select Edit or Delete", "Edit", "Delete", "Cancel");
            if (r == DialogResult.Yes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row=brStockdata.Rows[e.RowIndex];
                s.Id = Int32.Parse(row.Cells["Id"].Value.ToString());
                s.Name = row.Cells["Name"].Value.ToString();
                s.Quantity = Int32.Parse(row.Cells["Quantity"].Value.ToString());
                s.Price = Int32.Parse(row.Cells["Price"].Value.ToString());
                s.DOM = (System.DateTime)row.Cells["DOM"].Value;
                s.Available = Int32.Parse(row.Cells["Available"].Value.ToString());
                s.Branch_Id = Int32.Parse(row.Cells["Branch_Id"].Value.ToString());

                editName.Text = s.Name;
                editQuntity.Text = s.Quantity + "";
                editAvailable.Text = s.Available + "";
                editPrice.Text = s.Price + "";
                editDOM.Value = s.DOM;
                editBranchList.SelectedIndex = Br_Id.IndexOf(s.Branch_Id);
                Edit.BringToFront();
            }
            else if (r == DialogResult.No)
            {
                DataGridViewRow row = brStockdata.Rows[e.RowIndex];

             

                ServiceStock.StockData data = new ServiceStock.StockData();
                data = ss.deleteStock(Int32.Parse(row.Cells["Id"].Value.ToString()));

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

        private void SearchStock_TextChanged(object sender, EventArgs e)
        {
            List<ServiceStock.StockData> searchdata = new List<ServiceStock.StockData>();

            foreach (ServiceStock.StockData i in stockdata)
            {
                string d = i.Id + i.Name + i.Available + i.Branch_Id + i.Branch_Location+i.DOM+i.Price+i.Quantity;
                if (d.ToLower().Contains(SearchStock.Text.ToLower()) == true)
                {
                    searchdata.Add(i);
                }

            }
            brStockdata.DataSource = searchdata;
        }

        private void ManageStock_Load(object sender, EventArgs e)
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

        private void ViewSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new ViewSales().ShowDialog();
        }

        private void selectbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectbranch.SelectedIndex>0)
            {
                stockdata = ss.selectStockperBranch(Br_Id[selectbranch.SelectedIndex]).ToList();
                brStockdata.DataSource = stockdata;
            }
        }
    }
}
