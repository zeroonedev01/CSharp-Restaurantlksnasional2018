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
    public partial class DialogPelanggan : Form
    {
        Config con = new Config();
        public static string id_pelanggan, nama = "";
        public DialogPelanggan()
        {
            InitializeComponent();
        }

        private void DialogPelanggan_Load(object sender, EventArgs e)
        {
            con.Tampil("SELECT * from tb_member", dataGridView1);
        }

        private void b_cari_Click(object sender, EventArgs e)
        {
            con.Cari("SELECT * from tb_member where id like '%" + t_cari.Text + "%' or Name like '%" + t_cari.Text + "%' or Email like '%" + t_cari.Text + "%' or Handphone like '%" + t_cari.Text + "%' or JoinDate like '%" + t_cari.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            id_pelanggan = dr.Cells[0].Value.ToString();
            nama = dr.Cells[1].Value.ToString();
            this.Close();
        }
        public string getId()
        {
            return id_pelanggan;
        }
        public string getNama()
        {
            return nama;
        }
    }
}
