namespace BSMSAdmin
{
    partial class ManageBranch
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
            this.Center = new System.Windows.Forms.Panel();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.editbranchbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.editlocationtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.branchdata = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.SearchBranch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllBranch = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.togglemenu = new System.Windows.Forms.Panel();
            this.ViewSale = new System.Windows.Forms.LinkLabel();
            this.managebil = new System.Windows.Forms.LinkLabel();
            this.managest = new System.Windows.Forms.LinkLabel();
            this.managead = new System.Windows.Forms.LinkLabel();
            this.managebr = new System.Windows.Forms.LinkLabel();
            this.Profile = new System.Windows.Forms.LinkLabel();
            this.Center.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.togglemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Center
            // 
            this.Center.BackColor = System.Drawing.Color.White;
            this.Center.Controls.Add(this.EditPanel);
            this.Center.Controls.Add(this.List);
            this.Center.Controls.Add(this.panel1);
            this.Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center.Location = new System.Drawing.Point(200, 0);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(969, 660);
            this.Center.TabIndex = 6;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.editbranchbtn);
            this.EditPanel.Controls.Add(this.label7);
            this.EditPanel.Controls.Add(this.editlocationtxt);
            this.EditPanel.Controls.Add(this.label8);
            this.EditPanel.Location = new System.Drawing.Point(29, 53);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(937, 583);
            this.EditPanel.TabIndex = 15;
            // 
            // editbranchbtn
            // 
            this.editbranchbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.editbranchbtn.FlatAppearance.BorderSize = 0;
            this.editbranchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editbranchbtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbranchbtn.ForeColor = System.Drawing.Color.White;
            this.editbranchbtn.Location = new System.Drawing.Point(304, 315);
            this.editbranchbtn.Name = "editbranchbtn";
            this.editbranchbtn.Size = new System.Drawing.Size(165, 38);
            this.editbranchbtn.TabIndex = 21;
            this.editbranchbtn.Text = "Edit Branch";
            this.editbranchbtn.UseVisualStyleBackColor = false;
            this.editbranchbtn.Click += new System.EventHandler(this.editbranchbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Location";
            // 
            // editlocationtxt
            // 
            this.editlocationtxt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlocationtxt.Location = new System.Drawing.Point(427, 249);
            this.editlocationtxt.Name = "editlocationtxt";
            this.editlocationtxt.Size = new System.Drawing.Size(212, 31);
            this.editlocationtxt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(297, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "Edit Branch";
            // 
            // List
            // 
            this.List.Controls.Add(this.label5);
            this.List.Controls.Add(this.branchdata);
            this.List.Controls.Add(this.Search);
            this.List.Controls.Add(this.SearchBranch);
            this.List.Location = new System.Drawing.Point(32, 49);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(937, 580);
            this.List.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(66, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "Branches";
            // 
            // branchdata
            // 
            this.branchdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branchdata.BackgroundColor = System.Drawing.Color.White;
            this.branchdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.branchdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.branchdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.branchdata.ColumnHeadersHeight = 25;
            this.branchdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.branchdata.Location = new System.Drawing.Point(61, 158);
            this.branchdata.MultiSelect = false;
            this.branchdata.Name = "branchdata";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.branchdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.branchdata.RowHeadersVisible = false;
            this.branchdata.RowHeadersWidth = 50;
            this.branchdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            this.branchdata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.branchdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branchdata.Size = new System.Drawing.Size(842, 402);
            this.branchdata.TabIndex = 11;
            this.branchdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(645, 22);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(63, 23);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            // 
            // SearchBranch
            // 
            this.SearchBranch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBranch.Location = new System.Drawing.Point(711, 22);
            this.SearchBranch.Name = "SearchBranch";
            this.SearchBranch.Size = new System.Drawing.Size(212, 31);
            this.SearchBranch.TabIndex = 9;
            this.SearchBranch.TextChanged += new System.EventHandler(this.SearchBranch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.AllBranch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 43);
            this.panel1.TabIndex = 0;
            // 
            // AllBranch
            // 
            this.AllBranch.ActiveLinkColor = System.Drawing.Color.White;
            this.AllBranch.AutoSize = true;
            this.AllBranch.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllBranch.ForeColor = System.Drawing.Color.White;
            this.AllBranch.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AllBranch.LinkColor = System.Drawing.Color.White;
            this.AllBranch.Location = new System.Drawing.Point(16, 9);
            this.AllBranch.Name = "AllBranch";
            this.AllBranch.Size = new System.Drawing.Size(87, 22);
            this.AllBranch.TabIndex = 1;
            this.AllBranch.TabStop = true;
            this.AllBranch.Text = "All Branch";
            this.AllBranch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllBranch_LinkClicked);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.togglemenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 660);
            this.panel3.TabIndex = 5;
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
            this.ViewSale.Location = new System.Drawing.Point(26, 324);
            this.ViewSale.Name = "ViewSale";
            this.ViewSale.Size = new System.Drawing.Size(95, 23);
            this.ViewSale.TabIndex = 28;
            this.ViewSale.TabStop = true;
            this.ViewSale.Text = "View Sales";
            this.ViewSale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewSale_LinkClicked);
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
            // ManageBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 660);
            this.Controls.Add(this.Center);
            this.Controls.Add(this.panel3);
            this.Name = "ManageBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBranch";
            this.Load += new System.EventHandler(this.ManageBranch_Load);
            this.Center.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.List.ResumeLayout(false);
            this.List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.togglemenu.ResumeLayout(false);
            this.togglemenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Center;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel togglemenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel AllBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel List;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView branchdata;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchBranch;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button editbranchbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editlocationtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel managebr;
        private System.Windows.Forms.LinkLabel Profile;
        private System.Windows.Forms.LinkLabel managebil;
        private System.Windows.Forms.LinkLabel managest;
        private System.Windows.Forms.LinkLabel managead;
        private System.Windows.Forms.LinkLabel ViewSale;
    }
}