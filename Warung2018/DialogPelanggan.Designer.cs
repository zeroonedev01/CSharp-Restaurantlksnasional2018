namespace Warung2018
{
    partial class DialogPelanggan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_cari = new System.Windows.Forms.Button();
            this.t_cari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 199);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // b_cari
            // 
            this.b_cari.Location = new System.Drawing.Point(226, 8);
            this.b_cari.Name = "b_cari";
            this.b_cari.Size = new System.Drawing.Size(75, 23);
            this.b_cari.TabIndex = 44;
            this.b_cari.Text = "Search";
            this.b_cari.UseVisualStyleBackColor = true;
            this.b_cari.Click += new System.EventHandler(this.b_cari_Click);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(12, 11);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(199, 20);
            this.t_cari.TabIndex = 43;
            // 
            // DialogPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 245);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_cari);
            this.Controls.Add(this.t_cari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPelanggan";
            this.Text = "DialogPelanggan";
            this.Load += new System.EventHandler(this.DialogPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_cari;
        private System.Windows.Forms.TextBox t_cari;
    }
}