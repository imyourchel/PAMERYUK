namespace PAMERYUK
{
    partial class FormNotifikasi
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
            this.dataGridViewPertemanan = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPertemanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPertemanan
            // 
            this.dataGridViewPertemanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPertemanan.Location = new System.Drawing.Point(53, 157);
            this.dataGridViewPertemanan.Name = "dataGridViewPertemanan";
            this.dataGridViewPertemanan.RowHeadersWidth = 51;
            this.dataGridViewPertemanan.RowTemplate.Height = 24;
            this.dataGridViewPertemanan.Size = new System.Drawing.Size(297, 340);
            this.dataGridViewPertemanan.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(400, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(448, 340);
            this.listBox1.TabIndex = 3;
            // 
            // FormNotifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.Notifikasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridViewPertemanan);
            this.Name = "FormNotifikasi";
            this.Text = "FormNotifikasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPertemanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPertemanan;
        private System.Windows.Forms.ListBox listBox1;
    }
}