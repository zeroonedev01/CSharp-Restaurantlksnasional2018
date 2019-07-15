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
using System.Collections;

namespace Warung2018
{
    public partial class FViewOrder : Form
    {
        SqlCommand cmd;
        Config con = new Config();
        SqlDataReader reader;
        SqlDataAdapter adapter;
        string idorder;
        bool statcmb = false;
        public FViewOrder()
        {
            InitializeComponent();
            GetIdOrder();
           


        }
        private void fillGrid()
        {
            
            cmd = new SqlCommand("SELECT Id, Name, Qty, Status FROM v_detailmenu where Orderid = '" + cmb_id.Text + "'", con.Buka());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                    dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
                dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[1];
                dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[2];
                DataGridViewComboBoxCell cell
                = (DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells[3];              
                cell.Value = dt.Rows[i].ItemArray[3];
            }
            dataGridView1.Refresh();
        
           

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
        private void FViewOrder_Load(object sender, EventArgs e) 
        {
           
        }
        private void addcoloum()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Status";
            combo.Items.Add("Preparation");
            combo.Items.Add("Cooking");
            combo.Items.Add("Delivered");
            dataGridView1.Columns.Add("", "Id");
            dataGridView1.Columns.Add("", "Name");
            dataGridView1.Columns.Add("", "Qty");
            dataGridView1.Columns.Insert(3, combo);
            dataGridView1.Columns[0].Visible = false;
        }
        private void cmb_id_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            addcoloum();
            fillGrid();
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow dgvrow = dataGridView1.CurrentRow;
                    con.CUD("UPDATE tb_orderdetail set Status = '" + dgvrow.Cells[3].Value.ToString() + "' where Id= '" + dgvrow.Cells[0].Value.ToString() + "'", "Sukses mengubah Status");
                }
                
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_cari_Click(object sender, EventArgs e)
        {
            con.Cari("SELECT Name, sum(Qty) as Qty FROM[dbo].[v_detailmenu] where Status <> 'Delivered'  and Name like '%" + t_cari.Text + "%' group by Name, Menuid order by Menuid", dataGridView2);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }
        void jajal()
        {
            con.Tampil("SELECT Name, sum(Qty) as Qty FROM[dbo].[v_detailmenu] where Status <> 'Delivered' group by Name, Menuid order by Menuid", dataGridView2);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        if (cmb_id.Text != "")
                        {
                            dataGridView1.Rows.Clear();
                            fillGrid();
                        }
                     
                        break;
                    }
                case 1:
                    { jajal();  }
                    break;
                default:
                    break;
            }
        }

        private void cmb_short_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Sort(dataGridView2.Columns[cmb_short.Text], ListSortDirection.Ascending);
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            string nama = dr.Cells[0].Value.ToString();
            cmd = new SqlCommand("SELECT Id,Name, Status, Qty from v_detailmenu where Name= '" + nama + "' and Status <>'delivered' order by Id asc offset 0 rows fetch next 2 rows only; ", con.Buka());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //flowLayoutPanel1.Controls.Clear();
            if (dt.Rows.Count == 2)
            {
                t_1.Text = dt.Rows[0]["Qty"].ToString();
                t_2.Text = dt.Rows[1]["Qty"].ToString();
                t_id1.Text = dt.Rows[0]["Id"].ToString();
                t_id2.Text = dt.Rows[1]["Id"].ToString();
                t_status1.SelectedItem = dt.Rows[0]["Status"].ToString();
                t_status2.SelectedItem = dt.Rows[1]["Status"].ToString();





            }
            else if (dt.Rows.Count ==1)
            {
                t_1.Text = dt.Rows[0]["Qty"].ToString();
                t_id1.Text = dt.Rows[0]["Id"].ToString();
                t_status1.SelectedItem = dt.Rows[0]["Status"].ToString();
                t_2.Text = "0";
                t_id2.Text = "0";
                t_status2.SelectedItem = "Preparation";
            }
            
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    Label l = new Label();
            //    l.Name = "tid" + i;
            //    l.Font = new Font("Arial", 12, FontStyle.Bold);
            //    l.Text = dt.Rows[i]["Id"].ToString();

            //    Label ll = new Label();
            //    ll.Name = "tqty" + i;
            //    ll.Text = dt.Rows[i]["Qty"].ToString();

            //    ComboBox combo = new ComboBox();
            //    combo.Items.Add("Preparation");
            //    combo.Items.Add("Cooking");
            //    combo.Items.Add("Delivered");
            //    combo.Name = "cmb_status" + i;
            //    combo.SelectedText= dt.Rows[i]["Status"].ToString();

            //    flowLayoutPanel1.Controls.Add(l);
            //    flowLayoutPanel1.Controls.Add(ll);
            //    flowLayoutPanel1.Controls.Add(combo);


            //}

        }

        private void t_status1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statcmb == true)
            {
                if (t_id1.Text == "0")
                {

                }
                else
                {
                    con.CUD("UPDATE tb_orderdetail set Status = '" + t_status1.Text + "' where Id= '" + t_id1.Text + "'", "Sukses Mengubah Data!  ");
                    statcmb = false;
                    jajal();
                    if (t_status1.SelectedItem.ToString() == "Delivered")
                    {
                        t_1.Text = "0";
                        t_id1.Text = "0";
                        t_status1.SelectedItem = "Preparation";
                    }

                }
            }






        }

        private void t_status2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statcmb==true)
            {
                if (t_id2.Text=="0")
                {

                }
                else
                {
                    con.CUD("UPDATE tb_orderdetail set Status = '" + t_status2.Text + "' where Id= '" + t_id2.Text + "'", "Sukses Mengubah Data!  ");
                    statcmb = false;
                    jajal();
                    if (t_status2.SelectedItem.ToString() == "Delivered")
                    {
                        t_2.Text = "0";
                        t_id2.Text = "0";
                        t_status2.SelectedItem = "Preparation";
                    }
               
                }
            }
           




        }

        private void t_status1_Click(object sender, EventArgs e)
        {
            statcmb = true;
            
        }

        private void t_status2_Click(object sender, EventArgs e)
        {
            statcmb = true;
        }
    }
}
