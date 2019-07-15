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
    public partial class MMenu : Form
    {
        Config con = new Config();
        public MMenu()
        {
            InitializeComponent();
            setup();
        }
        private void b_cari_Click(object sender, EventArgs e)
        {
            con.Cari("SELECT * from tb_menu where Name like '%" + t_cari.Text+ "%' or Price like '%" +t_cari.Text + "%'  ", dataGridView1);
        }
        private void MMenu_Load(object sender, EventArgs e)
        {

        }
        private void awal()
        {
            t_id.Clear();
            t_nama.Clear();
            t_price.Clear();
            t_protein.Clear();
            t_photo.Clear();
            t_carbo.Clear();
            t_nama.Focus();
            pictureBox1.Image = null;
           
            con.Tampil("SELECT * from tb_menu", dataGridView1);

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_price.Text = dr.Cells[2].Value.ToString();
            t_photo.Text = dr.Cells[3].Value.ToString();
            t_carbo.Text = dr.Cells[4].Value.ToString();
            t_protein.Text = dr.Cells[5].Value.ToString();
            if (System.IO.File.Exists( dr.Cells["Photo"].Value.ToString()))
            {
                
                 pictureBox1.Image = Image.FromFile(dr.Cells["Photo"].Value.ToString());
                
            }
           
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

        private void b_delete_Click(object sender, EventArgs e)
        {
            b_insert.Enabled = true;
            b_edit.Enabled = true;
            b_delete.Enabled = false;
            b_save.Enabled = true;
            b_cancel.Enabled = true;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            setup();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (t_nama.Text=="" || t_price.Text=="" ||t_protein.Text==""||t_photo.Text==""||t_carbo.Text=="")
            {
                MessageBox.Show("Semua Data harus Diisi");
            }
            else
            {
                if (b_delete.Enabled == false)
                {

                    if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.CUD("DELETE from tb_menu where Id = '" + t_id.Text + "' ", "Data Berhasil dihapus!");
                    }
                }
                else if (b_edit.Enabled == false)
                {
                    //string fname = t_nama.Text + ".jpg";
                    //string folder = @"D:\\cobagambar\";
                    //string pathstring = System.IO.Path.Combine(folder, fname);
                    //Image a = pictureBox1.Image;
                    //if (System.IO.File.Exists(t_photo.Text))
                    //{
   
                    //    System.IO.File.Delete(t_photo.Text);
                    //    a.Save(pathstring);
                        
                    //}
                    con.CUD("UPDATE tb_menu set Name ='" + t_nama.Text + "', Price ='" + t_price.Text + "',  Photo= '" + t_photo.Text + "', Carbo = '" + t_carbo.Text + "', Protein = '" + t_protein.Text + "' where id = '" + t_id.Text + "'", "Sukses Megubah Data");

                }
                else if (b_insert.Enabled == false)
                {
                    string fname = t_nama.Text + ".jpg";
                    string folder = @"D:\\cobagambar\";
                    string pathstring = System.IO.Path.Combine(folder, fname);
                    Image a = pictureBox1.Image;
                    a.Save(pathstring);
                    con.CUD("INSERT INTO tb_menu(Name,Price,Photo,Carbo,Protein) values('" + t_nama.Text + "','" + t_price.Text + "', '" + pathstring+ "','" + t_carbo.Text + "', '" + t_protein.Text + "')", "Sukses Menambahkan Data");
                }
                else
                {
                }
            }
            setup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                openFileDialog1.Filter = "(*.jpg;*.jpeg;*.bmp); |*.jpg;*.jpeg;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void t_nama_Leave(object sender, EventArgs e)
        {
            t_photo.Text = @"D:\\cobagambar\" + t_nama.Text;
        }
    }
}
