namespace BSMSAdmin
{
    partial class ManageStock
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
            this.AllStock = new System.Windows.Forms.LinkLabel();
            this.Add = new System.Windows.Forms.Panel();
            this.BranchList = new System.Windows.Forms.ComboBox();
            this.StockQuntity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StockDOM = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.StockPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NewStockbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.StockName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Panel();
            this.editAvailable = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.editBranchList = new System.Windows.Forms.ComboBox();
            this.editQuntity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editDOM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.editPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editStockbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.editName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Panel();
            this.selectbranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brStockdata = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.SearchStock = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Panel();
            this.NewStock = new System.Windows.Forms.LinkLabel();
            this.managebil = new System.Windows.Forms.LinkLabel();
            this.managest = new System.Windows.Forms.LinkLabel();
            this.center = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.togglemenu = new System.Windows.Forms.Panel();
            this.ViewSale = new System.Windows.Forms.LinkLabel();
            this.managead = new System.Windows.Forms.LinkLabel();
            this.managebr = new System.Windows.Forms.LinkLabel();
            this.Profile = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Add.SuspendLayout();
            this.Edit.SuspendLayout();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brStockdata)).BeginInit();
            this.header.SuspendLayout();
            this.center.SuspendLayout();
            this.panel3.SuspendLayout();
            this.togglemenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllStock
            // 
            this.AllStock.ActiveLinkColor = System.Drawing.Color.White;
            this.AllStock.AutoSize = true;
            this.AllStock.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStock.ForeColor = System.Drawing.Color.White;
            this.AllStock.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AllStock.LinkColor = System.Drawing.Color.White;
            this.AllStock.Location = new System.Drawing.Point(16, 9);
            this.AllStock.Name = "AllStock";
            this.AllStock.Size = new System.Drawing.Size(74, 22);
            this.AllStock.TabIndex = 1;
            this.AllStock.TabStop = true;
            this.AllStock.Text = "All Stock";
            this.AllStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllStock_LinkClicked);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Controls.Add(this.BranchList);
            this.Add.Controls.Add(this.StockQuntity);
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.StockDOM);
            this.Add.Controls.Add(this.label9);
            this.Add.Controls.Add(this.StockPrice);
            this.Add.Controls.Add(this.label10);
            this.Add.Controls.Add(this.NewStockbtn);
            this.Add.Controls.Add(this.label11);
            this.Add.Controls.Add(this.label12);
            this.Add.Controls.Add(this.StockName);
            this.Add.Controls.Add(this.label13);
            this.Add.Location = new System.Drawing.Point(15, 56);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(922, 568);
            this.Add.TabIndex = 3;
            // 
            // BranchList
            // 
            this.BranchList.BackColor = System.Drawing.Color.MediumPurple;
            this.BranchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BranchList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchList.ForeColor = System.Drawing.Color.White;
            this.BranchList.FormattingEnabled = true;
            this.BranchList.Location = new System.Drawing.Point(401, 368);
            this.BranchList.Name = "BranchList";
            this.BranchList.Size = new System.Drawing.Size(358, 31);
            this.BranchList.TabIndex = 60;
            // 
            // StockQuntity
            // 
            this.StockQuntity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuntity.Location = new System.Drawing.Point(401, 204);
            this.StockQuntity.Name = "StockQuntity";
            this.StockQuntity.Size = new System.Drawing.Size(358, 31);
            this.StockQuntity.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Branch";
            // 
            // StockDOM
            // 
            this.StockDOM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockDOM.Location = new System.Drawing.Point(401, 315);
            this.StockDOM.Name = "StockDOM";
            this.StockDOM.Size = new System.Drawing.Size(358, 31);
            this.StockDOM.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "DOM";
            // 
            // StockPrice
            // 
            this.StockPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockPrice.Location = new System.Drawing.Point(401, 258);
            this.StockPrice.Name = "StockPrice";
            this.StockPrice.Size = new System.Drawing.Size(358, 31);
            this.StockPrice.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "Price";
            // 
            // NewStockbtn
            // 
            this.NewStockbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.NewStockbtn.FlatAppearance.BorderSize = 0;
            this.NewStockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewStockbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStockbtn.ForeColor = System.Drawing.Color.White;
            this.NewStockbtn.Location = new System.Drawing.Point(423, 440);
            this.NewStockbtn.Name = "NewStockbtn";
            this.NewStockbtn.Size = new System.Drawing.Size(165, 38);
            this.NewStockbtn.TabIndex = 52;
            this.NewStockbtn.Text = "Add Stock";
            this.NewStockbtn.UseVisualStyleBackColor = false;
            this.NewStockbtn.Click += new System.EventHandler(this.NewStockbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 23);
            this.label11.TabIndex = 51;
            this.label11.Text = "Qantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(338, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 23);
            this.label12.TabIndex = 50;
            this.label12.Text = "Name";
            // 
            // StockName
            // 
            this.StockName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockName.Location = new System.Drawing.Point(401, 149);
            this.StockName.Name = "StockName";
            this.StockName.Size = new System.Drawing.Size(358, 31);
            this.StockName.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumPurple;
            this.label13.Location = new System.Drawing.Point(335, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 38);
            this.label13.TabIndex = 48;
            this.label13.Text = "New Stock";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.White;
            this.Edit.Controls.Add(this.editAvailable);
            this.Edit.Controls.Add(this.label15);
            this.Edit.Controls.Add(this.editBranchList);
            this.Edit.Controls.Add(this.editQuntity);
            this.Edit.Controls.Add(this.label2);
            this.Edit.Controls.Add(this.editDOM);
            this.Edit.Controls.Add(this.label3);
            this.Edit.Controls.Add(this.editPrice);
            this.Edit.Controls.Add(this.label4);
            this.Edit.Controls.Add(this.editStockbtn);
            this.Edit.Controls.Add(this.label7);
            this.Edit.Controls.Add(this.label8);
            this.Edit.Controls.Add(this.editName);
            this.Edit.Controls.Add(this.label14);
            this.Edit.Location = new System.Drawing.Point(12, 59);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(922, 568);
            this.Edit.TabIndex = 4;
            // 
            // editAvailable
            // 
            this.editAvailable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAvailable.Location = new System.Drawing.Point(321, 263);
            this.editAvailable.Name = "editAvailable";
            this.editAvailable.Size = new System.Drawing.Size(358, 31);
            this.editAvailable.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(231, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 23);
            this.label15.TabIndex = 73;
            this.label15.Text = "Available";
            // 
            // editBranchList
            // 
            this.editBranchList.BackColor = System.Drawing.Color.MediumPurple;
            this.editBranchList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editBranchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBranchList.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBranchList.ForeColor = System.Drawing.Color.White;
            this.editBranchList.FormattingEnabled = true;
            this.editBranchList.Location = new System.Drawing.Point(321, 428);
            this.editBranchList.Name = "editBranchList";
            this.editBranchList.Size = new System.Drawing.Size(358, 31);
            this.editBranchList.TabIndex = 72;
            // 
            // editQuntity
            // 
            this.editQuntity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuntity.Location = new System.Drawing.Point(321, 204);
            this.editQuntity.Name = "editQuntity";
            this.editQuntity.Size = new System.Drawing.Size(358, 31);
            this.editQuntity.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "Branch";
            // 
            // editDOM
            // 
            this.editDOM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDOM.Location = new System.Drawing.Point(321, 375);
            this.editDOM.Name = "editDOM";
            this.editDOM.Size = new System.Drawing.Size(358, 31);
            this.editDOM.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "DOM";
            // 
            // editPrice
            // 
            this.editPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPrice.Location = new System.Drawing.Point(321, 318);
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(358, 31);
            this.editPrice.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 66;
            this.label4.Text = "Price";
            // 
            // editStockbtn
            // 
            this.editStockbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.editStockbtn.FlatAppearance.BorderSize = 0;
            this.editStockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editStockbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStockbtn.ForeColor = System.Drawing.Color.White;
            this.editStockbtn.Location = new System.Drawing.Point(347, 486);
            this.editStockbtn.Name = "editStockbtn";
            this.editStockbtn.Size = new System.Drawing.Size(165, 38);
            this.editStockbtn.TabIndex = 65;
            this.editStockbtn.Text = "Edit Stock";
            this.editStockbtn.UseVisualStyleBackColor = false;
            this.editStockbtn.Click += new System.EventHandler(this.editStockbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Qantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Name";
            // 
            // editName
            // 
            this.editName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editName.Location = new System.Drawing.Point(321, 149);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(358, 31);
            this.editName.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumPurple;
            this.label14.Location = new System.Drawing.Point(255, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 38);
            this.label14.TabIndex = 61;
            this.label14.Text = "Edit Stock";
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.White;
            this.All.Controls.Add(this.selectbranch);
            this.All.Controls.Add(this.label5);
            this.All.Controls.Add(this.brStockdata);
            this.All.Controls.Add(this.Search);
            this.All.Controls.Add(this.SearchStock);
            this.All.Location = new System.Drawing.Point(21, 49);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(948, 589);
            this.All.TabIndex = 2;
            // 
            // selectbranch
            // 
            this.selectbranch.BackColor = System.Drawing.Color.MediumPurple;
            this.selectbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectbranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectbranch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbranch.ForeColor = System.Drawing.Color.White;
            this.selectbranch.FormattingEnabled = true;
            this.selectbranch.Location = new System.Drawing.Point(370, 25);
            this.selectbranch.Name = "selectbranch";
            this.selectbranch.Size = new System.Drawing.Size(212, 31);
            this.selectbranch.TabIndex = 23;
            this.selectbranch.SelectedIndexChanged += new System.EventHandler(this.selectbranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(53, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stocks";
            // 
            // brStockdata
            // 
            this.brStockdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brStockdata.BackgroundColor = System.Drawing.Color.White;
            this.brStockdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.brStockdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brStockdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.brStockdata.ColumnHeadersHeight = 25;
            this.brStockdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.brStockdata.Location = new System.Drawing.Point(22, 114);
            this.brStockdata.MultiSelect = false;
            this.brStockdata.Name = "brStockdata";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brStockdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.brStockdata.RowHeadersVisible = false;
            this.brStockdata.RowHeadersWidth = 50;
            this.brStockdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.brStockdata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.brStockdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brStockdata.Size = new System.Drawing.Size(842, 446);
            this.brStockdata.TabIndex = 16;
            this.brStockdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brStockdata_CellContentClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(602, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(63, 23);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            // 
            // SearchStock
            // 
            this.SearchStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStock.Location = new System.Drawing.Point(668, 25);
            this.SearchStock.Name = "SearchStock";
            this.SearchStock.Size = new System.Drawing.Size(212, 31);
            this.SearchStock.TabIndex = 14;
            this.SearchStock.TextChanged += new System.EventHandler(this.SearchStock_TextChanged);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MediumPurple;
            this.header.Controls.Add(this.NewStock);
            this.header.Controls.Add(this.AllStock);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(969, 43);
            this.header.TabIndex = 1;
            // 
            // NewStock
            // 
            this.NewStock.ActiveLinkColor = System.Drawing.Color.White;
            this.NewStock.AutoSize = true;
            this.NewStock.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStock.ForeColor = System.Drawing.Color.White;
            this.NewStock.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NewStock.LinkColor = System.Drawing.Color.White;
            this.NewStock.Location = new System.Drawing.Point(109, 9);
            this.NewStock.Name = "NewStock";
            this.NewStock.Size = new System.Drawing.Size(80, 22);
            this.NewStock.TabIndex = 2;
            this.NewStock.TabStop = true;
            this.NewStock.Text = "New Stock";
            this.NewStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewStock_LinkClicked);
            // 
            // managebil
            // 
            this.managebil.ActiveLinkColor = System.Drawing.Color.White;
            this.managebil.AutoSize = true;
            this.managebil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managebil.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.managebil.LinkColor = System.Drawing.Color.White;
            this.managebil.Location = new System.Drawing.Point(26, 286);
            this.managebil.Name = "managebil";
            this.managebil.Size = new System.Drawing.Size(112, 23);
            this.managebil.TabIndex = 26;
            this.managebil.TabStop = true;
            this.managebil.Text = "Manage Bills";
            this.managebil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managebil_LinkClicked);
            // 
            // managest
            // 
            this.managest.ActiveLinkColor = System.Drawing.Color.White;
            this.managest.AutoSize = true;
            this.managest.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managest.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.managest.LinkColor = System.Drawing.Color.White;
            this.managest.Location = new System.Drawing.Point(26, 248);
            this.managest.Name = "managest";
            this.managest.Size = new System.Drawing.Size(121, 23);
            this.managest.TabIndex = 25;
            this.managest.TabStop = true;
            this.managest.Text = "Manage Stock";
            this.managest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managest_LinkClicked);
            // 
            // center
            // 
            this.center.Controls.Add(this.All);
            this.center.Controls.Add(this.Edit);
            this.center.Controls.Add(this.Add);
            this.center.Controls.Add(this.header);
            this.center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center.Location = new System.Drawing.Point(200, 0);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(969, 660);
            this.center.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
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
            this.panel3.TabIndex = 9;
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
            this.togglemenu.Controls.Add(this.ViewSale);
            this.togglemenu.Controls.Add(this.managebil);
            this.togglemenu.Controls.Add(this.managest);
            this.togglemenu.Controls.Add(this.managead);
            this.togglemenu.Controls.Add(this.managebr);
            this.togglemenu.Controls.Add(this.Profile);
            this.togglemenu.Controls.Add(this.panel2);
            this.togglemenu.Location = new System.Drawing.Point(3, 59);
            this.togglemenu.Name = "togglemenu";
            this.togglemenu.Size = new System.Drawing.Size(200, 364);
            this.togglemenu.TabIndex = 8;
            // 
            // ViewSale
            // 
            this.ViewSale.ActiveLinkColor = System.Drawing.Color.White;
            this.ViewSale.AutoSize = true;
            this.ViewSale.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSale.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ViewSale.LinkColor = System.Drawing.Color.White;
            this.ViewSale.Location = new System.Drawing.Point(26, 326);
            this.ViewSale.Name = "ViewSale";
            this.ViewSale.Size = new System.Drawing.Size(95, 23);
            this.ViewSale.TabIndex = 28;
            this.ViewSale.TabStop = true;
            this.ViewSale.Text = "View Sales";
            this.ViewSale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewSale_LinkClicked);
            // 
            // managead
            // 
            this.managead.ActiveLinkColor = System.Drawing.Color.White;
            this.managead.AutoSize = true;
            this.managead.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managead.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.managead.LinkColor = System.Drawing.Color.White;
            this.managead.Location = new System.Drawing.Point(26, 211);
            this.managead.Name = "managead";
            this.managead.Size = new System.Drawing.Size(121, 23);
            this.managead.TabIndex = 24;
            this.managead.TabStop = true;
            this.managead.Text = "Manage Biller";
            this.managead.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managead_LinkClicked);
            // 
            // managebr
            // 
            this.managebr.ActiveLinkColor = System.Drawing.Color.White;
            this.managebr.AutoSize = true;
            this.managebr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managebr.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.managebr.LinkColor = System.Drawing.Color.White;
            this.managebr.Location = new System.Drawing.Point(26, 173);
            this.managebr.Name = "managebr";
            this.managebr.Size = new System.Drawing.Size(133, 23);
            this.managebr.TabIndex = 23;
            this.managebr.TabStop = true;
            this.managebr.Text = "Manage Branch";
            this.managebr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managebr_LinkClicked);
            // 
            // Profile
            // 
            this.Profile.ActiveLinkColor = System.Drawing.Color.White;
            this.Profile.AutoSize = true;
            this.Profile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Profile.LinkColor = System.Drawing.Color.White;
            this.Profile.Location = new System.Drawing.Point(29, 139);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(63, 23);
            this.Profile.TabIndex = 22;
            this.Profile.TabStop = true;
            this.Profile.Text = "Profile";
            this.Profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Profile_LinkClicked);
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
            // ManageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 660);
            this.Controls.Add(this.center);
            this.Controls.Add(this.panel3);
            this.Name = "ManageStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStock";
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.All.ResumeLayout(false);
            this.All.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brStockdata)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.center.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.togglemenu.ResumeLayout(false);
            this.togglemenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel AllStock;
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.Panel All;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.LinkLabel NewStock;
        private System.Windows.Forms.LinkLabel managebil;
        private System.Windows.Forms.LinkLabel managest;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.Panel Edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel togglemenu;
        private System.Windows.Forms.LinkLabel managead;
        private System.Windows.Forms.LinkLabel managebr;
        private System.Windows.Forms.LinkLabel Profile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView brStockdata;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchStock;
        private System.Windows.Forms.TextBox StockQuntity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker StockDOM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StockPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button NewStockbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox StockName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox BranchList;
        private System.Windows.Forms.ComboBox editBranchList;
        private System.Windows.Forms.TextBox editQuntity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker editDOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editStockbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox editAvailable;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel ViewSale;
        private System.Windows.Forms.ComboBox selectbranch;
    }
}