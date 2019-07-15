namespace Warung2018
{
    partial class FOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_order = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.t_qty = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_cari = new System.Windows.Forms.Button();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.t_carbo = new System.Windows.Forms.Label();
            this.t_protein = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.Label();
            this.t_idpel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_namapelanggan = new System.Windows.Forms.TextBox();
            this.b_pembeli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "From Order";
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(725, 310);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(105, 39);
            this.b_delete.TabIndex = 70;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_order
            // 
            this.b_order.Location = new System.Drawing.Point(398, 551);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(105, 24);
            this.b_order.TabIndex = 69;
            this.b_order.Text = "Order";
            this.b_order.UseVisualStyleBackColor = true;
            this.b_order.Click += new System.EventHandler(this.b_order_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(586, 310);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(105, 39);
            this.b_add.TabIndex = 68;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // t_qty
            // 
            this.t_qty.Location = new System.Drawing.Point(607, 284);
            this.t_qty.Name = "t_qty";
            this.t_qty.Size = new System.Drawing.Size(223, 20);
            this.t_qty.TabIndex = 66;
            // 
            // t_nama
            // 
            this.t_nama.Enabled = false;
            this.t_nama.Location = new System.Drawing.Point(607, 258);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(223, 20);
            this.t_nama.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 162);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 54);
            this.panel1.TabIndex = 56;
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(223, 234);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(75, 23);
            this.b_cari.TabIndex = 73;
            this.b_cari.Text = "Search";
            this.b_cari.UseVisualStyleBackColor = true;
            this.b_cari.Click += new System.EventHandler(this.b_cari_Click);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(18, 237);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(199, 20);
            this.t_cari.TabIndex = 72;
            this.t_cari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(331, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 354);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(872, 191);
            this.dataGridView2.TabIndex = 75;
            // 
            // t_carbo
            // 
            this.t_carbo.AutoSize = true;
            this.t_carbo.Location = new System.Drawing.Point(15, 551);
            this.t_carbo.Name = "t_carbo";
            this.t_carbo.Size = new System.Drawing.Size(35, 13);
            this.t_carbo.TabIndex = 76;
            this.t_carbo.Text = "label2";
            // 
            // t_protein
            // 
            this.t_protein.AutoSize = true;
            this.t_protein.Location = new System.Drawing.Point(182, 551);
            this.t_protein.Name = "t_protein";
            this.t_protein.Size = new System.Drawing.Size(35, 13);
            this.t_protein.TabIndex = 77;
            this.t_protein.Text = "label5";
            // 
            // t_total
            // 
            this.t_total.AutoSize = true;
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.Location = new System.Drawing.Point(676, 551);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(47, 15);
            this.t_total.TabIndex = 78;
            this.t_total.Text = "label5";
            // 
            // t_idpel
            // 
            this.t_idpel.Enabled = false;
            this.t_idpel.Location = new System.Drawing.Point(607, 228);
            this.t_idpel.Name = "t_idpel";
            this.t_idpel.Size = new System.Drawing.Size(40, 20);
            this.t_idpel.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Pembeli";
            // 
            // t_namapelanggan
            // 
            this.t_namapelanggan.Enabled = false;
            this.t_namapelanggan.Location = new System.Drawing.Point(653, 228);
            this.t_namapelanggan.Name = "t_namapelanggan";
            this.t_namapelanggan.Size = new System.Drawing.Size(143, 20);
            this.t_namapelanggan.TabIndex = 81;
            // 
            // b_pembeli
            // 
            this.b_pembeli.Location = new System.Drawing.Point(802, 226);
            this.b_pembeli.Name = "b_pembeli";
            this.b_pembeli.Size = new System.Drawing.Size(28, 23);
            this.b_pembeli.TabIndex = 83;
            this.b_pembeli.Text = "...";
            this.b_pembeli.UseVisualStyleBackColor = true;
            this.b_pembeli.Click += new System.EventHandler(this.b_pembeli_Click);
            // 
            // FOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 581);
            this.Controls.Add(this.b_pembeli);
            this.Controls.Add(this.t_namapelanggan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_idpel);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.t_protein);
            this.Controls.Add(this.t_carbo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_cari);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_order);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_qty);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FOrder";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_order;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.TextBox t_qty;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label t_carbo;
        private System.Windows.Forms.Label t_protein;
        private System.Windows.Forms.Label t_total;
        private System.Windows.Forms.TextBox t_idpel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_namapelanggan;
        private System.Windows.Forms.Button b_pembeli;
    }
}