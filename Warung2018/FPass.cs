using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Warung2018
{
    public partial class FPass : Form
    {
        Config con = new Config();
        Flogin log = new Flogin();
        AdminNavigation admin = new AdminNavigation();
        SqlDataReader reader;
        SqlCommand cmd;
        string pass;
        public FPass()
        {
            InitializeComponent();
            ambilData();
            setAwal();


        }
        private void ambilData()
        {
            try
            {
                cmd = new SqlCommand("SELECT password from tb_employee where Id = '"+Flogin.getId()+"'",con.Buka());
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pass = reader["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                con.Tutup();
            }
        }
        void setAwal()
        {
            tcpass.Clear();
            tpbaru.Clear();
            tplama.Clear();
            tplama.Focus();
        }
        private void FPass_Load(object sender, EventArgs e)
        {
            
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            con.setSHA512(tplama.Text);
            string hasil = con.getSHA512();
            if (tplama.Text == "" || tpbaru.Text == "" || tcpass.Text =="")
            {
                MessageBox.Show("Isilah Semua textboxt yang tersedia!","Informasi");
            }
            else if(hasil!=pass)
            {
                MessageBox.Show("Password lama salah, silahkan cek kembali", "Informasi");
                tplama.Clear();
            }
            else if (tpbaru.Text!=tcpass.Text)
            {
                MessageBox.Show("Password tidak sama!", "Informasi");
                tcpass.Clear();
            }
            else
            {
                con.setSHA512(tpbaru.Text);
                string newpass = con.getSHA512();
                con.CUD("UPDATE tb_employee set password = '"+newpass+"' where Id= '"+Flogin.getId()+"'","Password telah berhasil Diubah");
                setAwal(); 
            }
            
        }
        

    }
}
