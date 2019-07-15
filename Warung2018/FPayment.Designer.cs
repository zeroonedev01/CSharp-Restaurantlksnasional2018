namespace Warung2018
{
    partial class FPayment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_total = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.t_bank = new System.Windows.Forms.ComboBox();
            this.t_card = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.t_bayar = new System.Windows.Forms.TextBox();
            this.t_kembali = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 54);
            this.panel1.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "From Payment";
            // 
            // cmb_id
            // 
            this.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(191, 83);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(164, 21);
            this.cmb_id.TabIndex = 60;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Order Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 226);
            this.dataGridView1.TabIndex = 61;
            // 
            // t_total
            // 
            this.t_total.AutoSize = true;
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.Location = new System.Drawing.Point(436, 371);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(79, 20);
            this.t_total.TabIndex = 79;
            this.t_total.Text = "Total = 0";
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.cmb_type.Location = new System.Drawing.Point(191, 374);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(194, 21);
            this.cmb_type.TabIndex = 81;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Payment Type";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(73, 429);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(63, 13);
            this.t2.TabIndex = 82;
            this.t2.Text = "Nama Bank";
            // 
            // t_bank
            // 
            this.t_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_bank.FormattingEnabled = true;
            this.t_bank.Items.AddRange(new object[] {
            "BRI",
            "BNI"});
            this.t_bank.Location = new System.Drawing.Point(191, 429);
            this.t_bank.Name = "t_bank";
            this.t_bank.Size = new System.Drawing.Size(194, 21);
            this.t_bank.TabIndex = 83;
            // 
            // t_card
            // 
            this.t_card.Location = new System.Drawing.Point(191, 400);
            this.t_card.Name = "t_card";
            this.t_card.Size = new System.Drawing.Size(194, 20);
            this.t_card.TabIndex = 85;
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(73, 403);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(69, 13);
            this.t1.TabIndex = 84;
            this.t1.Text = "Card Number";
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(191, 460);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(105, 30);
            this.b_save.TabIndex = 86;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // t_bayar
            // 
            this.t_bayar.Location = new System.Drawing.Point(191, 401);
            this.t_bayar.Name = "t_bayar";
            this.t_bayar.Size = new System.Drawing.Size(194, 20);
            this.t_bayar.TabIndex = 87;
            this.t_bayar.TextChanged += new System.EventHandler(this.t_bayar_TextChanged);
            // 
            // t_kembali
            // 
            this.t_kembali.Location = new System.Drawing.Point(191, 429);
            this.t_kembali.Name = "t_kembali";
            this.t_kembali.Size = new System.Drawing.Size(194, 20);
            this.t_kembali.TabIndex = 88;
            // 
            // FPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 496);
            this.Controls.Add(this.t_bayar);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.t_card);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t_bank);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.t_kembali);
            this.Name = "FPayment";
            this.Text = "FPayment";
            this.Load += new System.EventHandler(this.FPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label t_total;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.ComboBox t_bank;
        private System.Windows.Forms.TextBox t_card;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TextBox t_bayar;
        private System.Windows.Forms.TextBox t_kembali;
    }
}