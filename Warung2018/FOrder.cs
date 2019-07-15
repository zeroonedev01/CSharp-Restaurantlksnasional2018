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

namespace Warung2018
{
    public partial class FOrder : Form
    {
        Config con = new Config();
        string id, Price, Carbo, Protein, urut;
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        public FOrder()
        {
            InitializeComponent();
            awal();
            autonumber();
            b_pembeli.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void autonumber()
        {
            long hitung;
            cmd = new SqlCommand("SELECT id From tb_orderHeader where id in (select max(id) from tb_orderHeader where Date = CONVERT (date, GETDATE())) order by id desc", con.Buka());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = DateTime.Now.ToString("yyyyMMdd") + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = DateTime.Now.ToString("yyyyMMdd") +"0001";
            }
            reader.Close();
            con.Tutup();

        }
        private void b_cari_Click(object sender, EventArgs e)
        {
            con.Cari("SELECT * from tb_menu where Name like '%"+t_cari.Text+ "%' or Price like '%" + t_cari.Text + "%' or id like '%" + t_cari.Text + "%'", dataGridView1);
        }
        private void b_add_Click(object sender, EventArgs e)
        {
            if (t_nama.Text =="" || t_qty.TextLength == 0)
            {
                MessageBox.Show("Pilih data yang akan diorder!");

            }
            else
            {
                int x = Convert.ToInt32(Price) * Convert.ToInt32(t_qty.Text);
                dt.Rows.Add(id, t_nama.Text, t_qty.Text, Carbo, Protein, Price, x);
                this.dataGridView2.DataSource = dt;
            }
            Bersih();
            hitung();
           
        }
        private void hitung()
        {
            int sumTotal = 0;
          
            int totkarbo = 0;
            int totProtein = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                int a = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                int b = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                int karbo = a * b;
                int x = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                int z = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);
                int pro = x * z;
                totProtein += pro;
                totkarbo += karbo;
                sumTotal += Convert.ToInt32(dataGridView2.Rows[i].Cells[6].Value);
            }
            t_total.Text = "Total = "+sumTotal.ToString();
            t_carbo.Text = "Carbo = " +totkarbo.ToString();
            t_protein.Text = "Protein = " + totProtein.ToString();
        }
        private void b_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count>1)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView2.DataSource = dt;
            }
            hitung();
          
        }
        private void Bersih()
        {
            t_qty.Clear();
            t_nama.Clear();
        }
        private void b_pembeli_Click(object sender, EventArgs e)
        {
            DialogPelanggan dp = new DialogPelanggan();
            dp.ShowDialog();
            t_idpel.Text = dp.getId();
            t_namapelanggan.Text = dp.getNama();
        }
        private void simpanMaster()
        {
            con.CUD("INSERT into tb_orderHeader(id,Emp_id,Mem_id,Date) values('"+urut+ "', '" + Flogin.getId() + "', '" + t_idpel.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')","Sukses Menambahkan Data!");

        }
        private void simpanDetail()
        {
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                con.CUDtrans("INSERT INTO tb_orderdetail (Orderid,Menuid,Qty,Status) values ('"+urut+"','"+ Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value)+"','"+dataGridView2.Rows[i].Cells[2].Value+"','Preparation')");
            }
        }
        private void b_order_Click(object sender, EventArgs e)
        {
            simpanMaster();
            simpanDetail();
            t_idpel.Clear();
            t_namapelanggan.Clear();
            Bersih();
            autonumber();
            dt.Rows.Clear();
            dataGridView2.Refresh();

        }
        private void awal()
        {
            con.Tampil("SELECT * from tb_menu",dataGridView1);
            dt.Columns.Add("Id Menu");
            dt.Columns.Add("Menu");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Carbo");
            dt.Columns.Add("Protein");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");
            dataGridView2.DataSource = dt;


        }
        private void FOrder_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            id = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            Price = dr.Cells[2].Value.ToString();
            Carbo= dr.Cells[4].Value.ToString();
            Protein= dr.Cells[5].Value.ToString();
            if (System.IO.File.Exists(dr.Cells["Photo"].Value.ToString()))
            {

                pictureBox1.Image = Image.FromFile(dr.Cells["Photo"].Value.ToString());

            }
        }
    }
}
