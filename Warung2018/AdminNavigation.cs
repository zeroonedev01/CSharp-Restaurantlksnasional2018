using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warung2018
{
    public partial class AdminNavigation : Form
    {
        Flogin f = new Flogin();
        public AdminNavigation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FPass p = new FPass();
            p.Show();
        }


        private void AdminNavigation_Load(object sender, EventArgs e)
        {
            t_nama.Text = "Welcome," + Flogin.getNama();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Anda akan Log Out?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MEmployee Me = new MEmployee();
            Me.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MMember mm = new MMember();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MMenu mm = new MMenu();
            mm.Show();
        }

        private void b_order_Click(object sender, EventArgs e)
        {
            FOrder fo = new FOrder();
            fo.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FReport fr = new FReport();
            fr.Show();
        }
    }
}
