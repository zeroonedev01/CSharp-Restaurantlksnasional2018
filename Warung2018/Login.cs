using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warung2018
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private string hasil;
        private void Login_Load(object sender, EventArgs e)
        {
            

        }
        private string GenerateSHA512(string awal)
        {
            SHA512 key = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(awal);
            byte[] hash = key.ComputeHash(bytes);
            hasil= Convert.ToBase64String(hash);
            return hasil;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateSHA512(t_awal.Text);
            t_encrip.Text = hasil;
     
        }

        private void b_decript_Click(object sender, EventArgs e)
        {
            
        }
    }
}
