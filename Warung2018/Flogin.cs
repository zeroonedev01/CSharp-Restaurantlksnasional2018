using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Warung2018
{
    public partial class Flogin : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataReader reader;
        static string id, nama;
        string pos;
        
        public Flogin()
        {
            InitializeComponent();

        }
        public static string getId()
        {
            return id;
        }
        public static string getNama()
        {
            return nama;
        } 
        private void t_uname_Leave(object sender, EventArgs e)
        {
            if (t_uname.Text== "")
            {
                t_uname.Text = "example@ls.com";
                t_uname.ForeColor = Color.Silver;
            }
        }

        private void t_uname_Enter(object sender, EventArgs e)
        {
            if (t_uname.Text == "example@ls.com")
            {
                t_uname.Text = "";
                t_uname.ForeColor = Color.Black;
            }
        }

        private void t_pass_Leave(object sender, EventArgs e)
        {
            if (t_pass.Text == "")
            {
                t_pass.Text = "Password";
                t_pass.ForeColor = Color.Silver;
                t_pass.UseSystemPasswordChar = false;
            }
        }

        private void t_pass_Enter(object sender, EventArgs e)
        {
            if (t_pass.Text == "Password")
            {
                t_pass.Text = "";
                t_pass.ForeColor = Color.Black;
                t_pass.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (t_uname.Text==null || t_pass.Text==null)
            {
                MessageBox.Show("Perikasa Kembali Email dan Password!");
            }
            else
            {
                try
                {
                    con.setSHA512(t_pass.Text);
                    cmd = new SqlCommand("SELECT * from tb_employee where Email = '" + t_uname.Text + "' and password ='" +con.getSHA512() + "' ", con.Buka());
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nama = reader["Name"].ToString();
                            pos = reader["Position"].ToString();
                            id = reader["Id"].ToString();
                        }
                        if (pos.Equals("admin"))
                        {
                            MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminNavigation a = new AdminNavigation();
                            a.Show();
                            this.Hide();
                           

                        }
                        else if (pos.Equals("cashier"))
                        {
                            CashierNav n = new CashierNav();
                            n.Show();
                            this.Hide();
                            MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (pos.Equals("chef"))
                        {
                            ChefNav c = new ChefNav();
                            c.Show();
                            this.Hide();
                            MessageBox.Show("Login Berhasil!","Informasi",MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Login Gagal", "Informasi");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan atau password anda salah!","Informasi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        t_uname.Clear();
                        t_pass.Clear();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Tutup();
                }
            }
            
        }

        private void Flogin_Load(object sender, EventArgs e)
        {
            
        }

        private void t_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Anda akan Keluar Aplikasi?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
