namespace PAMERYUK
{
    partial class FormDaftarBlock
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
            this.dataGridViewBlock = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBlock
            // 
            this.dataGridViewBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBlock.Location = new System.Drawing.Point(52, 210);
            this.dataGridViewBlock.Name = "dataGridViewBlock";
            this.dataGridViewBlock.RowHeadersWidth = 51;
            this.dataGridViewBlock.RowTemplate.Height = 24;
            this.dataGridViewBlock.Size = new System.Drawing.Size(795, 279);
            this.dataGridViewBlock.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(297, 171);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(418, 30);
            this.textBoxSearch.TabIndex = 3;
            // 
            // FormDaftarBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.Daftar_user_yang_di_blokir;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewBlock);
            this.Name = "FormDaftarBlock";
            this.Text = "FormDaftarBlock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBlock;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}