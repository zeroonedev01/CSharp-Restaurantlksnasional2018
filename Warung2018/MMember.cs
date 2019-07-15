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
    public partial class MMember : Form
    {
        Config con = new Config();
        public MMember()
        {
            InitializeComponent();
            setup();
        }
        private void MMember_Load(object sender, EventArgs e)
        {

        }
        private void awal()
        {
            t_id.Clear();
            t_nama.Clear();
            t_email.Clear();
            t_hp.Clear();
            t_nama.Focus();
            con.Tampil("SELECT * from tb_member", dataGridView1);

        }
        private void setup()
        {
            b_save.Enabled = false;
            b_cancel.Enabled = false;
            b_insert.Enabled = true;
            b_delete.Enabled = true;
            b_edit.Enabled = true;
            awal();
        }
        private void b_cari_Click(object sender, EventArgs e)
        {
            con.Cari("SELECT * from tb_member where id like '%" + t_cari.Text + "%' or Name like '%" + t_cari.Text + "%' or Email like '%" + t_cari.Text + "%' or Handphone like '%" + t_cari.Text + "%' or JoinDate like '%" + t_cari.Text + "%'", dataGridView1);
        }
        private void b_insert_Click(object sender, EventArgs e)
        {
           
        }
        private void b_edit_Click(object sender, EventArgs e)
        {
        }
        private void b_update_Click(object sender, EventArgs e)
        { 
        }
        private void b_cancel_Click(object sender, EventArgs e)
        {
         
        }
        private void b_delete_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_email.Text = dr.Cells[2].Value.ToString();
            t_hp.Text = dr.Cells[3].Value.ToString();
        }
        private void b_edit_Click_1(object sender, EventArgs e)
        {
            if (t_id.Text!="")
            {
                b_insert.Enabled = true;
                b_delete.Enabled = true;
                b_edit.Enabled = false;
                b_save.Enabled = true;
                b_cancel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan diedit!");
            }
        }
        private void b_delete_Click_1(object sender, EventArgs e)
        {
            if (t_id.Text != "")
            {
                b_insert.Enabled = true;
                b_edit.Enabled = true;
                b_delete.Enabled = false;
                b_save.Enabled = true;
                b_cancel.Enabled = true;
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan didelete!");
            }
        }
        private void b_cancel_Click_1(object sender, EventArgs e)
        {
            setup();
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            if (t_nama.Text == "" || t_email.Text == "" || t_hp.Text == "")
            {
                MessageBox.Show("Semua Data harus Diisi");
            }
            else
            {
                if (b_delete.Enabled == false)
                {

                    if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.CUD("DELETE from tb_member where id = '" + t_id.Text + "' ", "Data Berhasil dihapus!");
                    }
                }
                else if (b_edit.Enabled == false)
                {
                    con.CUD("UPDATE tb_member set Name ='" + t_nama.Text + "', Email ='" + t_email.Text + "',  Handphone= '" + t_hp.Text + "' where id = '" + t_id.Text + "'", "Sukses Megubah Data");
                }
                else if (b_insert.Enabled == false)
                {
                    string tanggal = DateTime.Now.ToString("yyyy-MM-dd");
                    con.CUD("INSERT INTO tb_member (Name, Email, Handphone, JoinDate) values('" + t_nama.Text + "','" + t_email.Text + "','" + t_hp.Text + "','" + tanggal + "')", "Sukses Menambahkan Data");
                }
                else
                {
                }
            }
            setup();
        }
        private void b_insert_Click_1(object sender, EventArgs e)
        {
            setup();
            b_insert.Enabled = false;
            b_save.Enabled = true;
            b_cancel.Enabled = true;
        }
    }
}
