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
            this.viewbills = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.togglemenu = new System.Windows.Forms.Panel();
            this.Createbill = new System.Windows.Forms.LinkLabel();
            this.profilebtn = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.center = new System.Windows.Forms.Panel();
            this.billlerdob = new System.Windows.Forms.DateTimePicker();
            this.contactcontact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editprofilebtn = new System.Windows.Forms.Button();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.billerpassword = new System.Windows.Forms.TextBox();
            this.billeremail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // viewbills
            // 
            this.viewbills.ActiveLinkColor = System.Drawing.Color.White;
            this.viewbills.AutoSize = true;
            this.viewbills.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbills.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewbills.LinkColor = System.Drawing.Color.White;
            this.viewbills.Location = new System.Drawing.Point(29, 177);
            this.viewbills.Name = "viewbills";
            this.viewbills.Size = new System.Drawing.Size(88, 23);
            this.viewbills.TabIndex = 26;
            this.viewbills.TabStop = true;
            this.viewbills.Text = "View Bills";
            this.viewbills.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewbills_LinkClicked);
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
            this.Createbill.Location = new System.Drawing.Point(29, 218);
            this.Createbill.Name = "Createbill";
            this.Createbill.Size = new System.Drawing.Size(85, 23);
            this.Createbill.TabIndex = 28;
            this.Createbill.TabStop = true;
            this.Createbill.Text = "New Bills";
            this.Createbill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Createbill_LinkClicked);
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
            this.center.Controls.Add(this.billlerdob);
            this.center.Controls.Add(this.contactcontact);
            this.center.Controls.Add(this.label8);
            this.center.Controls.Add(this.label7);
            this.center.Controls.Add(this.editprofilebtn);
            this.center.Controls.Add(this.confirmpassword);
            this.center.Controls.Add(this.billerpassword);
            this.center.Controls.Add(this.billeremail);
            this.center.Controls.Add(this.label6);
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
            // billlerdob
            // 
            this.billlerdob.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billlerdob.Location = new System.Drawing.Point(614, 249);
            this.billlerdob.Name = "billlerdob";
            this.billlerdob.Size = new System.Drawing.Size(240, 31);
            this.billlerdob.TabIndex = 44;
            // 
            // contactcontact
            // 
            this.contactcontact.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactcontact.Location = new System.Drawing.Point(614, 187);
            this.contactcontact.Name = "contactcontact";
            this.contactcontact.Size = new System.Drawing.Size(240, 33);
            this.contactcontact.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumPurple;
            this.label8.Location = new System.Drawing.Point(537, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 33);
            this.label8.TabIndex = 42;
            this.label8.Text = "D.O.B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(518, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 33);
            this.label7.TabIndex = 41;
            this.label7.Text = "Contact";
            // 
            // editprofilebtn
            // 
            this.editprofilebtn.BackColor = System.Drawing.Color.MediumPurple;
            this.editprofilebtn.FlatAppearance.BorderSize = 0;
            this.editprofilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editprofilebtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editprofilebtn.ForeColor = System.Drawing.Color.White;
            this.editprofilebtn.Location = new System.Drawing.Point(324, 385);
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
            this.confirmpassword.Location = new System.Drawing.Point(249, 309);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(240, 33);
            this.confirmpassword.TabIndex = 14;
            // 
            // billerpassword
            // 
            this.billerpassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billerpassword.Location = new System.Drawing.Point(249, 245);
            this.billerpassword.Name = "billerpassword";
            this.billerpassword.Size = new System.Drawing.Size(240, 33);
            this.billerpassword.TabIndex = 13;
            // 
            // billeremail
            // 
            this.billeremail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billeremail.Location = new System.Drawing.Point(249, 185);
            this.billeremail.Name = "billeremail";
            this.billeremail.Size = new System.Drawing.Size(240, 33);
            this.billeremail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(42, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(42, 187);
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
            this.label3.Location = new System.Drawing.Point(42, 245);
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
            this.label2.Location = new System.Drawing.Point(42, 121);
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
        private System.Windows.Forms.LinkLabel viewbills;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel togglemenu;
        private System.Windows.Forms.LinkLabel profilebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.TextBox billerpassword;
        private System.Windows.Forms.TextBox billeremail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editprofilebtn;
        private System.Windows.Forms.LinkLabel Createbill;
        private System.Windows.Forms.DateTimePicker billlerdob;
        private System.Windows.Forms.TextBox contactcontact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}