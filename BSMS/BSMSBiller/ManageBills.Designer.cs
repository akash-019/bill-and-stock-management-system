﻿namespace BSMSAdmin
{
    partial class ManageBills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.togglemenu = new System.Windows.Forms.Panel();
            this.Createbill = new System.Windows.Forms.LinkLabel();
            this.viewbills = new System.Windows.Forms.LinkLabel();
            this.profilebtn = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.center = new System.Windows.Forms.Panel();
            this.All = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.branchBillsView = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.SearchBills = new System.Windows.Forms.TextBox();
            this.Products = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.saleproductview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Labelx = new System.Windows.Forms.Label();
            this.SearchProducts = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Panel();
            this.Bills = new System.Windows.Forms.LinkLabel();
            this.togglemenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.center.SuspendLayout();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBillsView)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleproductview)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(12, 71);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(47, 31);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(94, 23);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BSMS";
            // 
            // togglemenu
            // 
            this.togglemenu.BackColor = System.Drawing.Color.BlueViolet;
            this.togglemenu.Controls.Add(this.Createbill);
            this.togglemenu.Controls.Add(this.viewbills);
            this.togglemenu.Controls.Add(this.profilebtn);
            this.togglemenu.Controls.Add(this.panel2);
            this.togglemenu.Location = new System.Drawing.Point(3, 59);
            this.togglemenu.Name = "togglemenu";
            this.togglemenu.Size = new System.Drawing.Size(200, 364);
            this.togglemenu.TabIndex = 8;
            // 
            // Createbill
            // 
            this.Createbill.ActiveLinkColor = System.Drawing.Color.White;
            this.Createbill.AutoSize = true;
            this.Createbill.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createbill.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Createbill.LinkColor = System.Drawing.Color.White;
            this.Createbill.Location = new System.Drawing.Point(27, 211);
            this.Createbill.Name = "Createbill";
            this.Createbill.Size = new System.Drawing.Size(85, 23);
            this.Createbill.TabIndex = 31;
            this.Createbill.TabStop = true;
            this.Createbill.Text = "New Bills";
            this.Createbill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Createbill_LinkClicked);
            // 
            // viewbills
            // 
            this.viewbills.ActiveLinkColor = System.Drawing.Color.White;
            this.viewbills.AutoSize = true;
            this.viewbills.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbills.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewbills.LinkColor = System.Drawing.Color.White;
            this.viewbills.Location = new System.Drawing.Point(27, 170);
            this.viewbills.Name = "viewbills";
            this.viewbills.Size = new System.Drawing.Size(88, 23);
            this.viewbills.TabIndex = 30;
            this.viewbills.TabStop = true;
            this.viewbills.Text = "View Bills";
            this.viewbills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewbills_LinkClicked);
            // 
            // profilebtn
            // 
            this.profilebtn.ActiveLinkColor = System.Drawing.Color.White;
            this.profilebtn.AutoSize = true;
            this.profilebtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.profilebtn.LinkColor = System.Drawing.Color.White;
            this.profilebtn.Location = new System.Drawing.Point(27, 132);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(63, 23);
            this.profilebtn.TabIndex = 29;
            this.profilebtn.TabStop = true;
            this.profilebtn.Text = "Profile";
            this.profilebtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.profilebtn_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 101);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.togglemenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 660);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // center
            // 
            this.center.Controls.Add(this.All);
            this.center.Controls.Add(this.Products);
            this.center.Controls.Add(this.header);
            this.center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center.Location = new System.Drawing.Point(200, 0);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(969, 660);
            this.center.TabIndex = 8;
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.White;
            this.All.Controls.Add(this.label5);
            this.All.Controls.Add(this.branchBillsView);
            this.All.Controls.Add(this.Search);
            this.All.Controls.Add(this.SearchBills);
            this.All.Location = new System.Drawing.Point(9, 62);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(922, 568);
            this.All.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(37, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "Bills";
            // 
            // branchBillsView
            // 
            this.branchBillsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branchBillsView.BackgroundColor = System.Drawing.Color.White;
            this.branchBillsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.branchBillsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.branchBillsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.branchBillsView.ColumnHeadersHeight = 25;
            this.branchBillsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.branchBillsView.Location = new System.Drawing.Point(44, 150);
            this.branchBillsView.MultiSelect = false;
            this.branchBillsView.Name = "branchBillsView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.branchBillsView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.branchBillsView.RowHeadersVisible = false;
            this.branchBillsView.RowHeadersWidth = 50;
            this.branchBillsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.branchBillsView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.branchBillsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branchBillsView.Size = new System.Drawing.Size(842, 402);
            this.branchBillsView.TabIndex = 20;
            this.branchBillsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brallBills_CellClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(604, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(63, 23);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            // 
            // SearchBills
            // 
            this.SearchBills.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBills.Location = new System.Drawing.Point(670, 16);
            this.SearchBills.Name = "SearchBills";
            this.SearchBills.Size = new System.Drawing.Size(212, 31);
            this.SearchBills.TabIndex = 18;
            this.SearchBills.TextChanged += new System.EventHandler(this.SearchBills_TextChanged);
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.White;
            this.Products.Controls.Add(this.label2);
            this.Products.Controls.Add(this.saleproductview);
            this.Products.Controls.Add(this.Labelx);
            this.Products.Controls.Add(this.SearchProducts);
            this.Products.Location = new System.Drawing.Point(12, 59);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(922, 568);
            this.Products.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sale Products";
            // 
            // saleproductview
            // 
            this.saleproductview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.saleproductview.BackgroundColor = System.Drawing.Color.White;
            this.saleproductview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.saleproductview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleproductview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.saleproductview.ColumnHeadersHeight = 25;
            this.saleproductview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.saleproductview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.saleproductview.Location = new System.Drawing.Point(44, 150);
            this.saleproductview.MultiSelect = false;
            this.saleproductview.Name = "saleproductview";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.saleproductview.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.saleproductview.RowHeadersVisible = false;
            this.saleproductview.RowHeadersWidth = 50;
            this.saleproductview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.saleproductview.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.saleproductview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.saleproductview.Size = new System.Drawing.Size(842, 402);
            this.saleproductview.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Labelx
            // 
            this.Labelx.AutoSize = true;
            this.Labelx.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelx.Location = new System.Drawing.Point(604, 16);
            this.Labelx.Name = "Labelx";
            this.Labelx.Size = new System.Drawing.Size(63, 23);
            this.Labelx.TabIndex = 23;
            this.Labelx.Text = "Search";
            // 
            // SearchProducts
            // 
            this.SearchProducts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProducts.Location = new System.Drawing.Point(670, 16);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(212, 31);
            this.SearchProducts.TabIndex = 22;
            this.SearchProducts.TextChanged += new System.EventHandler(this.SearchProducts_TextChanged);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MediumPurple;
            this.header.Controls.Add(this.Bills);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(969, 43);
            this.header.TabIndex = 1;
            // 
            // Bills
            // 
            this.Bills.ActiveLinkColor = System.Drawing.Color.White;
            this.Bills.AutoSize = true;
            this.Bills.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills.ForeColor = System.Drawing.Color.White;
            this.Bills.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Bills.LinkColor = System.Drawing.Color.White;
            this.Bills.Location = new System.Drawing.Point(16, 9);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(72, 22);
            this.Bills.TabIndex = 1;
            this.Bills.TabStop = true;
            this.Bills.Text = "All Bills";
            this.Bills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllBils_LinkClicked);
            // 
            // ManageBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 660);
            this.Controls.Add(this.center);
            this.Controls.Add(this.panel3);
            this.Name = "ManageBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBills";
            this.Load += new System.EventHandler(this.ManageBills_Load);
            this.togglemenu.ResumeLayout(false);
            this.togglemenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.center.ResumeLayout(false);
            this.All.ResumeLayout(false);
            this.All.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBillsView)).EndInit();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleproductview)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel togglemenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.LinkLabel Bills;
        private System.Windows.Forms.Panel Products;
        private System.Windows.Forms.Panel All;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView branchBillsView;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchBills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView saleproductview;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label Labelx;
        private System.Windows.Forms.TextBox SearchProducts;
        private System.Windows.Forms.LinkLabel Createbill;
        private System.Windows.Forms.LinkLabel viewbills;
        private System.Windows.Forms.LinkLabel profilebtn;
    }
}