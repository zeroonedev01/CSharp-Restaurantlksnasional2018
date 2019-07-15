using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;

namespace Warung2018
{
    class Config
    {
        private SqlCommand cmd;
        private SqlConnection cnn;
        private SqlDataAdapter adapter;
        private string strkoneksi = null;
        public string hasil;
        public SqlConnection Buka()
        {
            strkoneksi = "Server = DESKTOP-A45DNAG\\SQLEXPRESS; Database = rumah_makan; Integrated Security =SSPI;";
            cnn = new SqlConnection(strkoneksi);
            try
            {
                cnn.Open();
                //MessageBox.Show("Koenksi Tebua");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            return cnn;
        }
        public SqlConnection Tutup()
        {
            cnn.Close();
            return cnn;
        }
        public bool CUD(string query, string info)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
                MessageBox.Show(info, "informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Tutup();
            }
            return true;

        }
        public bool CUD1(string query)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Tutup();
            }
            return true;

        }
        public bool CUDtrans(string query)
        {
            try
            {
                cmd = new SqlCommand(query, Buka());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Tutup();
            }
            return true;

        }
        public bool Insert(string q1,string q2, string info)
        {
            try
            {
                SqlCommand cek = new SqlCommand(q1, Buka());
                int ada = Convert.ToInt32(cek.ExecuteScalar());
                if (ada>0)
                {
                    MessageBox.Show("Akun Sudah Ada!");
                }
                else
                {
                    cmd = new SqlCommand(q2, Buka());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(info, "informasi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                Tutup();
            }
            return true;
        }
        public string setSHA512(string awal)
        {
            SHA512 key = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(awal);
            byte[] hash = key.ComputeHash(bytes);
            hasil = Convert.ToBase64String(hash);
            return hasil;
        }
        public string getSHA512()
        {
            return hasil;
        }
        public void Tampil(string query, DataGridView dgr)
        {
            cmd = new SqlCommand(query,Buka());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgr.DataSource = dt;
            dgr.Refresh();
        }
        public void Cari(string query, DataGridView dgr)
        {
            cmd = new SqlCommand(query, Buka());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgr.DataSource = dt;
            dgr.Refresh();
        }

    }
}
