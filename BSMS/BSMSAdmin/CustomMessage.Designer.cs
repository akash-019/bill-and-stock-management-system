namespace BSMSAdmin
{
    partial class CustomMessage
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
            this.title = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.btnone = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(147, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Message Title";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.White;
            this.desc.Location = new System.Drawing.Point(14, 47);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(361, 20);
            this.desc.TabIndex = 1;
            this.desc.Text = "Select Which you want to Perform Edit or Delete ?";
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.MediumPurple;
            this.btnone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnone.ForeColor = System.Drawing.Color.White;
            this.btnone.Location = new System.Drawing.Point(18, 88);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(75, 23);
            this.btnone.TabIndex = 2;
            this.btnone.Text = "button1";
            this.btnone.UseVisualStyleBackColor = false;
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.Color.MediumPurple;
            this.btntwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntwo.ForeColor = System.Drawing.Color.White;
            this.btntwo.Location = new System.Drawing.Point(99, 88);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(75, 23);
            this.btntwo.TabIndex = 3;
            this.btntwo.Text = "button2";
            this.btntwo.UseVisualStyleBackColor = false;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.Color.MediumPurple;
            this.btnthree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthree.ForeColor = System.Drawing.Color.White;
            this.btnthree.Location = new System.Drawing.Point(338, 88);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(75, 23);
            this.btnthree.TabIndex = 4;
            this.btnthree.Text = "button3";
            this.btnthree.UseVisualStyleBackColor = false;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // CustomMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(450, 123);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnthree;
    }
}