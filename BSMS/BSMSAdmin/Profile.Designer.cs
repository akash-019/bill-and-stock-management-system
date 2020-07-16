namespace BSMSAdmin
{
    partial class Profile
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
            this.managebil = new System.Windows.Forms.LinkLabel();
            this.managest = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.togglemenu = new System.Windows.Forms.Panel();
            this.ViewSale = new System.Windows.Forms.LinkLabel();
            this.managead = new System.Windows.Forms.LinkLabel();
            this.managebr = new System.Windows.Forms.LinkLabel();
            this.profilebtn = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.center = new System.Windows.Forms.Panel();
            this.editprofilebtn = new System.Windows.Forms.Button();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.adminpassword = new System.Windows.Forms.TextBox();
            this.adminemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.togglemenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.header.SuspendLayout();
            this.center.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.TabIndex = 11;
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
            this.togglemenu.Controls.Add(this.profilebtn);
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
            this.ViewSale.Location = new System.Drawing.Point(26, 323);
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
            this.managead.Text = "Branch Admin";
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
            // profilebtn
            // 
            this.profilebtn.ActiveLinkColor = System.Drawing.Color.White;
            this.profilebtn.AutoSize = true;
            this.profilebtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.profilebtn.LinkColor = System.Drawing.Color.White;
            this.profilebtn.Location = new System.Drawing.Point(29, 139);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(63, 23);
            this.profilebtn.TabIndex = 22;
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
            this.panel2.Size = new System.Drawing.Size(194, 101);
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
            // header
            // 
            this.header.BackColor = System.Drawing.Color.MediumPurple;
            this.header.Controls.Add(this.Logout);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(969, 43);
            this.header.TabIndex = 1;
            // 
            // Logout
            // 
            this.Logout.ActiveLinkColor = System.Drawing.Color.White;
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Logout.LinkColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(16, 9);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(53, 22);
            this.Logout.TabIndex = 1;
            this.Logout.TabStop = true;
            this.Logout.Text = "logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // center
            // 
            this.center.Controls.Add(this.editprofilebtn);
            this.center.Controls.Add(this.confirmpassword);
            this.center.Controls.Add(this.adminpassword);
            this.center.Controls.Add(this.adminemail);
            this.center.Controls.Add(this.label6);
            this.center.Controls.Add(this.adminname);
            this.center.Controls.Add(this.label5);
            this.center.Controls.Add(this.label4);
            this.center.Controls.Add(this.label3);
            this.center.Controls.Add(this.label2);
            this.center.Controls.Add(this.header);
            this.center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center.Location = new System.Drawing.Point(200, 0);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(969, 660);
            this.center.TabIndex = 12;
            // 
            // editprofilebtn
            // 
            this.editprofilebtn.BackColor = System.Drawing.Color.MediumPurple;
            this.editprofilebtn.FlatAppearance.BorderSize = 0;
            this.editprofilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editprofilebtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editprofilebtn.ForeColor = System.Drawing.Color.White;
            this.editprofilebtn.Location = new System.Drawing.Point(226, 454);
            this.editprofilebtn.Name = "editprofilebtn";
            this.editprofilebtn.Size = new System.Drawing.Size(165, 38);
            this.editprofilebtn.TabIndex = 40;
            this.editprofilebtn.Text = "Edit Profile";
            this.editprofilebtn.UseVisualStyleBackColor = false;
            this.editprofilebtn.Click += new System.EventHandler(this.editprofilebtn_Click);
            // 
            // confirmpassword
            // 
            this.confirmpassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword.Location = new System.Drawing.Point(299, 372);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.PasswordChar = '*';
            this.confirmpassword.Size = new System.Drawing.Size(240, 33);
            this.confirmpassword.TabIndex = 14;
            this.confirmpassword.UseSystemPasswordChar = true;
            // 
            // adminpassword
            // 
            this.adminpassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpassword.Location = new System.Drawing.Point(299, 308);
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.PasswordChar = '*';
            this.adminpassword.Size = new System.Drawing.Size(240, 33);
            this.adminpassword.TabIndex = 13;
            this.adminpassword.UseSystemPasswordChar = true;
            // 
            // adminemail
            // 
            this.adminemail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminemail.Location = new System.Drawing.Point(299, 250);
            this.adminemail.Name = "adminemail";
            this.adminemail.Size = new System.Drawing.Size(240, 33);
            this.adminemail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(83, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // adminname
            // 
            this.adminname.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminname.Location = new System.Drawing.Point(299, 189);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(240, 33);
            this.adminname.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(83, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(83, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(83, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(83, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Details";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 660);
            this.Controls.Add(this.center);
            this.Controls.Add(this.panel3);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.togglemenu.ResumeLayout(false);
            this.togglemenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.center.ResumeLayout(false);
            this.center.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel managebil;
        private System.Windows.Forms.LinkLabel managest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel togglemenu;
        private System.Windows.Forms.LinkLabel managead;
        private System.Windows.Forms.LinkLabel managebr;
        private System.Windows.Forms.LinkLabel profilebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.TextBox adminpassword;
        private System.Windows.Forms.TextBox adminemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminname;
        private System.Windows.Forms.Button editprofilebtn;
        private System.Windows.Forms.LinkLabel ViewSale;
    }
}