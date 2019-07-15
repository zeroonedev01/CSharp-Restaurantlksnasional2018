namespace Warung2018
{
    partial class ChefNav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_logout = new System.Windows.Forms.Button();
            this.b_pass = new System.Windows.Forms.Button();
            this.b_pay = new System.Windows.Forms.Button();
            this.t_nama = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_logout
            // 
            this.b_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.b_logout.FlatAppearance.BorderSize = 0;
            this.b_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.ForeColor = System.Drawing.Color.White;
            this.b_logout.Location = new System.Drawing.Point(395, 165);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(184, 98);
            this.b_logout.TabIndex = 23;
            this.b_logout.Text = "LogOut";
            this.b_logout.UseVisualStyleBackColor = false;
            this.b_logout.Click += new System.EventHandler(this.b_logout_Click);
            // 
            // b_pass
            // 
            this.b_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.b_pass.FlatAppearance.BorderSize = 0;
            this.b_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pass.ForeColor = System.Drawing.Color.White;
            this.b_pass.Location = new System.Drawing.Point(205, 165);
            this.b_pass.Name = "b_pass";
            this.b_pass.Size = new System.Drawing.Size(184, 98);
            this.b_pass.TabIndex = 22;
            this.b_pass.Text = "Change Passsword";
            this.b_pass.UseVisualStyleBackColor = false;
            this.b_pass.Click += new System.EventHandler(this.b_pass_Click);
            // 
            // b_pay
            // 
            this.b_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.b_pay.FlatAppearance.BorderSize = 0;
            this.b_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pay.ForeColor = System.Drawing.Color.White;
            this.b_pay.Location = new System.Drawing.Point(15, 165);
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(184, 98);
            this.b_pay.TabIndex = 21;
            this.b_pay.Text = "View Order";
            this.b_pay.UseVisualStyleBackColor = false;
            this.b_pay.Click += new System.EventHandler(this.b_pay_Click);
            // 
            // t_nama
            // 
            this.t_nama.AutoSize = true;
            this.t_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_nama.Location = new System.Drawing.Point(12, 88);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(179, 16);
            this.t_nama.TabIndex = 20;
            this.t_nama.Text = "Welcome, [Admin Name]";
            this.t_nama.Click += new System.EventHandler(this.t_nama_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 71);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Chef Navigation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 34);
            this.panel2.TabIndex = 42;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zeref.Weismann 2018";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChefNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.b_pass);
            this.Controls.Add(this.b_pay);
            this.Controls.Add(this.t_nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefNav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefNav";
            this.Load += new System.EventHandler(this.ChefNav_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_logout;
        private System.Windows.Forms.Button b_pass;
        private System.Windows.Forms.Button b_pay;
        private System.Windows.Forms.Label t_nama;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}