using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Warung2018
{
    public partial class FReport : Form
    {
        SqlDataReader reader;
        SqlCommand cmd;
        Config con = new Config();
        int a, b;
        public FReport()
        {
            InitializeComponent();
        }

        private void b_gen_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            a = DateTime.ParseExact(cmb_awal.Text, "MMMM", CultureInfo.InvariantCulture).Month;
            b = DateTime.ParseExact(cmb_akhir.Text, "MMMM", CultureInfo.InvariantCulture).Month;

            con.Tampil("SELECT Month, Income from v_detail where Bulan between '"+a+"' and '"+b+"'  ", dataGridView1);
            fillChart();
        }
        private void fillChart()
        {
            cmd = new SqlCommand("SELECT Month, Income from v_detail where Bulan between '" + a + "' and '" + b + "'", con.Buka());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.chart1.Series["Income"].Points.AddXY(reader["Month"].ToString(), reader["Income"].ToString());
            }
            reader.Close();
            con.Tutup();

        }

        private void FReport_Load(object sender, EventArgs e)
        {
           
        }
    }
}
