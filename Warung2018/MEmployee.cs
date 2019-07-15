using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Warung2018
{
    public partial class MEmployee : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataReader reader;
        public MEmployee()
        {
            InitializeComponent();
            setup();
        }
        private void autonumber()
        {
            long hitung;
            string urut;
            cmd = new SqlCommand("SELECT Id from tb_employee where Id in (select max(Id) from tb_employee)order by Id desc",con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["Id"].ToString().Length -3, 3))+1;
                string joinstr = "000" + hitung;
                urut = "EM" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "EM001";
            }
            reader.Close();
            con.Tutup();
            t_id.Text = urut;
        }
        private void MEmployee_Load(object sender, EventArgs e)
        {
           
        }
        private void awal()
        {
            t_id.Clear();
            t_nama.Clear();
            t_email.Clear();
            t_hp.Clear();
            t_pos.SelectedItem = 0;
            autonumber();
            t_nama.Focus();
            con.Tampil("SELECT Id,Name,Email, Hp, Position from tb_employee", dataGridView1);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Cari("SELECT * from tb_employee where Id like '%"+t_cari.Text+ "%' or Name like '%" + t_cari.Text + "%' or Email like '%" + t_cari.Text + "%' or Position like '%" + t_cari.Text + "%'", dataGridView1);
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_email.Text = dr.Cells[2].Value.ToString();
            t_hp.Text = dr.Cells[3].Value.ToString();
            t_pos.Text = dr.Cells[4].Value.ToString();


        }
        private void b_insert_Click(object sender, EventArgs e)
        {
            setup();
            b_insert.Enabled = false;
            b_save.Enabled = true;
            b_cancel.Enabled = true;
        }
        private void b_edit_Click(object sender, EventArgs e)
        {
            b_insert.Enabled = true;
            b_delete.Enabled = true;
            b_edit.Enabled = false;
            b_save.Enabled = true;
            b_cancel.Enabled = true;
        }
        private void b_update_Click(object sender, EventArgs e)
        {
            if (t_id.Text == "" || t_nama.Text == "" || t_email.Text == "" || t_hp.Text == "" || t_pos.Text == "")
            {
                MessageBox.Show("Semua Data harus Diisi");
            }
            else 
            {
                if (b_delete.Enabled == false)
                {

                    if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.CUD("DELETE from tb_employee where Id = '" + t_id.Text + "' ", "Data Berhasil dihapus!");
                    }
                }
                else if (b_edit.Enabled == false)
                {
                    con.CUD("UPDATE tb_employee set Name ='" + t_nama.Text + "', Email ='" + t_email.Text + "',  Hp= '" + t_hp.Text + "', Position = '" + t_pos.Text + "' where Id = '" + t_id.Text + "'", "Sukses Megubah Data");
                } else if (b_insert.Enabled == false)
                {
                    string p = "password";
                    con.setSHA512(p);
                    string pass = con.getSHA512();
                    con.CUD("INSERT INTO tb_employee values('" + t_id.Text + "','" + t_nama.Text + "','" + t_email.Text + "', '" + pass + "','" + t_hp.Text + "', '" + t_pos.Text + "')", "Sukses Menambahkan Data");
                }
                else
                {
               }
            }
            setup();
        }
        private void b_cancel_Click(object sender, EventArgs e)
        {
            setup();
        }
        private void b_delete_Click(object sender, EventArgs e)
        {
            b_insert.Enabled = true;
            b_edit.Enabled = true;
            b_delete.Enabled = false;
            b_save.Enabled = true;
            b_cancel.Enabled = true;
        }
    }
}
