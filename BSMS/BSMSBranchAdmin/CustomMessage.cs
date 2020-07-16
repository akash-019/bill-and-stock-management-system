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
    public partial class CustomMessage : Form
    {
        public CustomMessage()
        {
            InitializeComponent();
        }
        static CustomMessage cm;
        static DialogResult r = DialogResult.Cancel;
        public static DialogResult Show(string title,string desc,string btnone,string btntwo,string btnthree)
        {
            cm = new CustomMessage();
            cm.title.Text = title;
            cm.desc.Text=desc;
            cm.btnone.Text = btnone;
            cm.btntwo.Text = btntwo;
            cm.btnthree.Text = btnthree;
            cm.ShowDialog();
            return r;
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            r = DialogResult.Yes;
            cm.Close();
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            r = DialogResult.No;
            cm.Close();
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            r = DialogResult.Cancel;
            cm.Close();
        }
    }
}
