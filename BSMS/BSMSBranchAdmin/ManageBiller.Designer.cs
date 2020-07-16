namespace BSMSAdmin
{
    partial class ManageBiller
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
            this.AllBrBiller = new System.Windows.Forms.LinkLabel();
            this.Add = new System.Windows.Forms.Panel();
            this.addcombobranch = new System.Windows.Forms.ComboBox();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.NewBrAdminpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewBrAdminDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.EmailId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NewBrAdminBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Panel();
            this.editcombobranch = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editDOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editContact = new System.Windows.Forms.TextBox();
            this.editbranchAdminbtn = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Panel();
            this.selectbranch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brBillderdata = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.SearchBranchAdmin = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Panel();
            this.NewBrAdmin = new System.Windows.Forms.LinkLabel();
            this.managebil = new System.Windows.Forms.LinkLabel();
            this.managest = new System.Windows.Forms.LinkLabel();
            this.center = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.togglemenu = new System.Windows.Forms.Panel();
            this.viewsale = new System.Windows.Forms.LinkLabel();
            this.managead = new System.Windows.Forms.LinkLabel();
            this.managebr = new System.Windows.Forms.LinkLabel();
            this.Profile = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Add.SuspendLayout();
            this.Edit.SuspendLayout();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brBillderdata)).BeginInit();
            this.header.SuspendLayout();
            this.center.SuspendLayout();
            this.panel3.SuspendLayout();
            this.togglemenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllBrBiller
            // 
            this.AllBrBiller.ActiveLinkColor = System.Drawing.Color.White;
            this.AllBrBiller.AutoSize = true;
            this.AllBrBiller.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBrBiller.ForeColor = System.Drawing.Color.White;
            this.AllBrBiller.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AllBrBiller.LinkColor = System.Drawing.Color.White;
            this.AllBrBiller.Location = new System.Drawing.Point(16, 9);
            this.AllBrBiller.Name = "AllBrBiller";
            this.AllBrBiller.Size = new System.Drawing.Size(134, 22);
            this.AllBrBiller.TabIndex = 1;
            this.AllBrBiller.TabStop = true;
            this.AllBrBiller.Text = "All Branch Biller";
            this.AllBrBiller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllBrAdmin_LinkClicked);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Controls.Add(this.addcombobranch);
            this.Add.Controls.Add(this.ContactNo);
            this.Add.Controls.Add(this.NewBrAdminpassword);
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.NewBrAdminDOB);
            this.Add.Controls.Add(this.label9);
            this.Add.Controls.Add(this.EmailId);
            this.Add.Controls.Add(this.label10);
            this.Add.Controls.Add(this.NewBrAdminBtn);
            this.Add.Controls.Add(this.label11);
            this.Add.Controls.Add(this.label12);
            this.Add.Controls.Add(this.label13);
            this.Add.Location = new System.Drawing.Point(6, 64);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(922, 596);
            this.Add.TabIndex = 3;
            // 
            // addcombobranch
            // 
            this.addcombobranch.BackColor = System.Drawing.Color.MediumPurple;
            this.addcombobranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addcombobranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addcombobranch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcombobranch.ForeColor = System.Drawing.Color.White;
            this.addcombobranch.FormattingEnabled = true;
            this.addcombobranch.Location = new System.Drawing.Point(401, 149);
            this.addcombobranch.Name = "addcombobranch";
            this.addcombobranch.Size = new System.Drawing.Size(212, 31);
            this.addcombobranch.TabIndex = 48;
            // 
            // ContactNo
            // 
            this.ContactNo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.Location = new System.Drawing.Point(401, 204);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(212, 31);
            this.ContactNo.TabIndex = 47;
            // 
            // NewBrAdminpassword
            // 
            this.NewBrAdminpassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBrAdminpassword.Location = new System.Drawing.Point(401, 368);
            this.NewBrAdminpassword.Name = "NewBrAdminpassword";
            this.NewBrAdminpassword.Size = new System.Drawing.Size(212, 31);
            this.NewBrAdminpassword.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Password";
            // 
            // NewBrAdminDOB
            // 
            this.NewBrAdminDOB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBrAdminDOB.Location = new System.Drawing.Point(401, 315);
            this.NewBrAdminDOB.Name = "NewBrAdminDOB";
            this.NewBrAdminDOB.Size = new System.Drawing.Size(212, 31);
            this.NewBrAdminDOB.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "DOB";
            // 
            // EmailId
            // 
            this.EmailId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailId.Location = new System.Drawing.Point(401, 258);
            this.EmailId.Name = "EmailId";
            this.EmailId.Size = new System.Drawing.Size(212, 31);
            this.EmailId.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "Email";
            // 
            // NewBrAdminBtn
            // 
            this.NewBrAdminBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.NewBrAdminBtn.FlatAppearance.BorderSize = 0;
            this.NewBrAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewBrAdminBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBrAdminBtn.ForeColor = System.Drawing.Color.White;
            this.NewBrAdminBtn.Location = new System.Drawing.Point(423, 440);
            this.NewBrAdminBtn.Name = "NewBrAdminBtn";
            this.NewBrAdminBtn.Size = new System.Drawing.Size(165, 38);
            this.NewBrAdminBtn.TabIndex = 39;
            this.NewBrAdminBtn.Text = "New Admin";
            this.NewBrAdminBtn.UseVisualStyleBackColor = false;
            this.NewBrAdminBtn.Click += new System.EventHandler(this.NewBrAdminBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 23);
            this.label11.TabIndex = 38;
            this.label11.Text = "Contact";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = "Branch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumPurple;
            this.label13.Location = new System.Drawing.Point(335, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 38);
            this.label13.TabIndex = 35;
            this.label13.Text = "New Branch Biller";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.White;
            this.Edit.Controls.Add(this.editcombobranch);
            this.Edit.Controls.Add(this.label14);
            this.Edit.Controls.Add(this.editPassword);
            this.Edit.Controls.Add(this.label4);
            this.Edit.Controls.Add(this.editDOB);
            this.Edit.Controls.Add(this.label3);
            this.Edit.Controls.Add(this.editEmail);
            this.Edit.Controls.Add(this.label2);
            this.Edit.Controls.Add(this.editContact);
            this.Edit.Controls.Add(this.editbranchAdminbtn);
            this.Edit.Controls.Add(this.Contact);
            this.Edit.Controls.Add(this.label8);
            this.Edit.Location = new System.Drawing.Point(12, 59);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(922, 608);
            this.Edit.TabIndex = 4;
            // 
            // editcombobranch
            // 
            this.editcombobranch.BackColor = System.Drawing.Color.MediumPurple;
            this.editcombobranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editcombobranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editcombobranch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editcombobranch.ForeColor = System.Drawing.Color.White;
            this.editcombobranch.FormattingEnabled = true;
            this.editcombobranch.Location = new System.Drawing.Point(230, 109);
            this.editcombobranch.Name = "editcombobranch";
            this.editcombobranch.Size = new System.Drawing.Size(212, 31);
            this.editcombobranch.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(158, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 23);
            this.label14.TabIndex = 51;
            this.label14.Text = "Branch";
            // 
            // editPassword
            // 
            this.editPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPassword.Location = new System.Drawing.Point(230, 324);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(212, 31);
            this.editPassword.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Password";
            // 
            // editDOB
            // 
            this.editDOB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDOB.Location = new System.Drawing.Point(230, 271);
            this.editDOB.Name = "editDOB";
            this.editDOB.Size = new System.Drawing.Size(212, 31);
            this.editDOB.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "DOB";
            // 
            // editEmail
            // 
            this.editEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmail.Location = new System.Drawing.Point(230, 214);
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(212, 31);
            this.editEmail.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            // 
            // editContact
            // 
            this.editContact.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContact.Location = new System.Drawing.Point(230, 160);
            this.editContact.Name = "editContact";
            this.editContact.Size = new System.Drawing.Size(212, 31);
            this.editContact.TabIndex = 28;
            // 
            // editbranchAdminbtn
            // 
            this.editbranchAdminbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.editbranchAdminbtn.FlatAppearance.BorderSize = 0;
            this.editbranchAdminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editbranchAdminbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbranchAdminbtn.ForeColor = System.Drawing.Color.White;
            this.editbranchAdminbtn.Location = new System.Drawing.Point(252, 396);
            this.editbranchAdminbtn.Name = "editbranchAdminbtn";
            this.editbranchAdminbtn.Size = new System.Drawing.Size(165, 38);
            this.editbranchAdminbtn.TabIndex = 27;
            this.editbranchAdminbtn.Text = "Edit Branch Biller";
            this.editbranchAdminbtn.UseVisualStyleBackColor = false;
            this.editbranchAdminbtn.Click += new System.EventHandler(this.editbranchAdminbtn_Click);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(153, 163);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(71, 23);
            this.Contact.TabIndex = 25;
            this.Contact.Text = "Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(164, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 38);
            this.label8.TabIndex = 22;
            this.label8.Text = "Edit Branch Biller";
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.White;
            this.All.Controls.Add(this.selectbranch);
            this.All.Controls.Add(this.label5);
            this.All.Controls.Add(this.brBillderdata);
            this.All.Controls.Add(this.Search);
            this.All.Controls.Add(this.SearchBranchAdmin);
            this.All.Location = new System.Drawing.Point(18, 49);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(948, 586);
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
            this.selectbranch.Location = new System.Drawing.Point(386, 26);
            this.selectbranch.Name = "selectbranch";
            this.selectbranch.Size = new System.Drawing.Size(212, 31);
            this.selectbranch.TabIndex = 24;
            this.selectbranch.SelectedIndexChanged += new System.EventHandler(this.selectbranch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(46, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 38);
            this.label5.TabIndex = 17;
            this.label5.Text = "Branch Biller";
            // 
            // brBillderdata
            // 
            this.brBillderdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.brBillderdata.BackgroundColor = System.Drawing.Color.White;
            this.brBillderdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.brBillderdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brBillderdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.brBillderdata.ColumnHeadersHeight = 25;
            this.brBillderdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.brBillderdata.Location = new System.Drawing.Point(53, 105);
            this.brBillderdata.MultiSelect = false;
            this.brBillderdata.Name = "brBillderdata";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.brBillderdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.brBillderdata.RowHeadersVisible = false;
            this.brBillderdata.RowHeadersWidth = 50;
            this.brBillderdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.brBillderdata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.brBillderdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.brBillderdata.Size = new System.Drawing.Size(842, 460);
            this.brBillderdata.TabIndex = 16;
            this.brBillderdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.brAdmindata_CellDoubleClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(613, 26);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(63, 23);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            // 
            // SearchBranchAdmin
            // 
            this.SearchBranchAdmin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBranchAdmin.Location = new System.Drawing.Point(679, 26);
            this.SearchBranchAdmin.Name = "SearchBranchAdmin";
            this.SearchBranchAdmin.Size = new System.Drawing.Size(212, 31);
            this.SearchBranchAdmin.TabIndex = 14;
            this.SearchBranchAdmin.TextChanged += new System.EventHandler(this.SearchBranchAdmin_TextChanged);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MediumPurple;
            this.header.Controls.Add(this.NewBrAdmin);
            this.header.Controls.Add(this.AllBrBiller);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(969, 43);
            this.header.TabIndex = 1;
            // 
            // NewBrAdmin
            // 
            this.NewBrAdmin.ActiveLinkColor = System.Drawing.Color.White;
            this.NewBrAdmin.AutoSize = true;
            this.NewBrAdmin.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBrAdmin.ForeColor = System.Drawing.Color.White;
            this.NewBrAdmin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NewBrAdmin.LinkColor = System.Drawing.Color.White;
            this.NewBrAdmin.Location = new System.Drawing.Point(174, 9);
            this.NewBrAdmin.Name = "NewBrAdmin";
            this.NewBrAdmin.Size = new System.Drawing.Size(140, 22);
            this.NewBrAdmin.TabIndex = 2;
            this.NewBrAdmin.TabStop = true;
            this.NewBrAdmin.Text = "New Branch Biller";
            this.NewBrAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewBrAdmin_LinkClicked);
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
            this.togglemenu.Controls.Add(this.viewsale);
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
            // viewsale
            // 
            this.viewsale.ActiveLinkColor = System.Drawing.Color.White;
            this.viewsale.AutoSize = true;
            this.viewsale.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewsale.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewsale.LinkColor = System.Drawing.Color.White;
            this.viewsale.Location = new System.Drawing.Point(26, 324);
            this.viewsale.Name = "viewsale";
            this.viewsale.Size = new System.Drawing.Size(95, 23);
            this.viewsale.TabIndex = 27;
            this.viewsale.TabStop = true;
            this.viewsale.Text = "View Sales";
            this.viewsale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewsale_LinkClicked);
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
            // ManageBiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 660);
            this.Controls.Add(this.center);
            this.Controls.Add(this.panel3);
            this.Name = "ManageBiller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Branch Admin";
            this.Load += new System.EventHandler(this.ManageBranchAdmin_Load);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            this.All.ResumeLayout(false);
            this.All.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brBillderdata)).EndInit();
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
        private System.Windows.Forms.LinkLabel AllBrBiller;
        private System.Windows.Forms.Panel Add;
        private System.Windows.Forms.Panel All;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.LinkLabel NewBrAdmin;
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
        private System.Windows.Forms.DataGridView brBillderdata;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchBranchAdmin;
        private System.Windows.Forms.TextBox editContact;
        private System.Windows.Forms.Button editbranchAdminbtn;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker editDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.TextBox NewBrAdminpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker NewBrAdminDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EmailId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button NewBrAdminBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel viewsale;
        private System.Windows.Forms.ComboBox selectbranch;
        private System.Windows.Forms.ComboBox addcombobranch;
        private System.Windows.Forms.ComboBox editcombobranch;
        private System.Windows.Forms.Label label14;
    }
}