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
    public partial class CashierNav : Form
    {
        Flogin f = new Flogin();
        public CashierNav()
        {
            InitializeComponent();
        }

        private void b_pay_Click(object sender, EventArgs e)
        {
           
        }

        private void CashierNav_Load(object sender, EventArgs e)
        {
            t_nama.Text = "Welcome," + Flogin.getNama();
        }

        private void b_logout_Click(object sender, EventArgs e)
        {
            
        }

        private void b_pass_Click(object sender, EventArgs e)
        {
           
        }

        private void b_pass_Click_1(object sender, EventArgs e)
        {
            FPass fp = new FPass();
            fp.Show();
        }

        private void b_pay_Click_1(object sender, EventArgs e)
        {
            FPayment fp = new FPayment();
            fp.Show();
        }

        private void b_logout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Anda akan Log Out?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                f.Show();
            }
        }
    }
}
