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
    public partial class FPayment : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string idorder;
        int kembali, sumTotal;
        public FPayment()
        {
            InitializeComponent();
            GetIdOrder();
            awal();

        }
        private void GetIdOrder()
        {
            cmd = new SqlCommand("SELECT id  from tb_orderHeader where PaymentType is NULL order by id desc", con.Buka());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                idorder = (string)reader["id"];
                cmb_id.Items.Add(idorder);
            }
            reader.Close();
            con.Tutup();
        }
        private void fillGrid()
        {
            con.Tampil("SELECT Name as Menu, Qty, Price, Total FROM v_detailmenu where Orderid = '" + cmb_id.Text + "'", dataGridView1);
        }
        private void hitung()
        {
          
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
 
                sumTotal += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            t_total.Text = "Total = " + sumTotal.ToString();

        }
        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
            hitung();
        }
        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_type.Text == "Cash")
            {
                bersih();
                t_bayar.Visible = true;
                t_kembali.Visible = true;
                t_card.Visible = false;
                t_bank.Visible = false;
                t1.Visible = true;
                t2.Visible = true;
                t1.Text = "Bayar";
                t2.Text = "Kembalian";
                t_kembali.Enabled = false;

            }
            else
            {
                bersih();
                t_bayar.Visible = false;
                t_kembali.Visible = false;
                t_card.Visible = true;
                t_bank.Visible = true;
                t1.Visible = true;
                t2.Visible = true;
                t1.Text = "Card Number";
                t2.Text = "Bak Name";
            }
        }
        private void bersih()
        {
            t_bayar.Clear();
            t_kembali.Clear();
            t_bank.SelectedIndex = 0;
            t_card.Clear();
        }
        private void awal()
        {
            bersih();
            t1.Visible = false;
            t2.Visible = false;
            t_bayar.Visible = false;
            t_kembali.Visible = false;
            t_card.Visible = false;
            t_bank.Visible = false;

        }
        private void FPayment_Load(object sender, EventArgs e)
        {
            
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (cmb_type.Text == "Cash")
            {
                if (t_bayar.TextLength!=0 )
                {
                    
                    con.CUD("UPDATE tb_orderHeader set Emp_id = '"+Flogin.getId()+ "', PaymentType = '"+cmb_type.Text+"' where id = '"+cmb_id.Text+"'","Transaksi Berhasil");
                    
                }
            }
            else
            {
                if (t_card.Text.Length!=0)
                {
                    
                    con.CUD("UPDATE tb_orderHeader set Emp_id = '" + Flogin.getId() + "', PaymentType = '" + cmb_type.Text + "', CardNumber ='"+t_card.Text+"', Bank = '"+t_bank.Text+"' where id = '" + cmb_id.Text + "'", "Transaksi Berhasil");
                }
            }
            bersih();
            dataGridView1.DataSource = null;
            cmb_id.Items.Clear();
            GetIdOrder();
        }

        private void t_bayar_TextChanged(object sender, EventArgs e)
        {
            int bayar = 0;
            if (Int32.TryParse(t_bayar.Text, out bayar))
            {
                kembali = bayar - sumTotal;
                t_kembali.Text = kembali.ToString();
                if (kembali < 0)
                {
                    t_bayar.Focus();
                    t_bayar.BackColor = Color.DarkOrange;
                }
                else
                {
                    t_bayar.BackColor = Color.LightGreen;
                    b_save.Enabled = true;
                }
            }

          
        }
    }
}
