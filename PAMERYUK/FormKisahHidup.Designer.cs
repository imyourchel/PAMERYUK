namespace PAMERYUK
{
    partial class FormKisahHidup
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
            this.comboBoxInstitution = new System.Windows.Forms.ComboBox();
            this.textBoxInstitutionName = new System.Windows.Forms.TextBox();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.comboBoxMonthStart = new System.Windows.Forms.ComboBox();
            this.comboBoxMonthEnd = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownYearStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYearEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInstitution
            // 
            this.comboBoxInstitution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstitution.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxInstitution.FormattingEnabled = true;
            this.comboBoxInstitution.Location = new System.Drawing.Point(466, 208);
            this.comboBoxInstitution.Name = "comboBoxInstitution";
            this.comboBoxInstitution.Size = new System.Drawing.Size(380, 31);
            this.comboBoxInstitution.TabIndex = 4;
            // 
            // textBoxInstitutionName
            // 
            this.textBoxInstitutionName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInstitutionName.Location = new System.Drawing.Point(466, 276);
            this.textBoxInstitutionName.Name = "textBoxInstitutionName";
            this.textBoxInstitutionName.Size = new System.Drawing.Size(380, 30);
            this.textBoxInstitutionName.TabIndex = 5;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Font = new System.Drawing.Font("Arial", 10F);
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.ItemHeight = 19;
            this.listBoxHistory.Location = new System.Drawing.Point(54, 177);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(380, 308);
            this.listBoxHistory.TabIndex = 7;
            // 
            // comboBoxMonthStart
            // 
            this.comboBoxMonthStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonthStart.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxMonthStart.FormattingEnabled = true;
            this.comboBoxMonthStart.Location = new System.Drawing.Point(466, 344);
            this.comboBoxMonthStart.Name = "comboBoxMonthStart";
            this.comboBoxMonthStart.Size = new System.Drawing.Size(175, 31);
            this.comboBoxMonthStart.TabIndex = 8;
            // 
            // comboBoxMonthEnd
            // 
            this.comboBoxMonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonthEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxMonthEnd.FormattingEnabled = true;
            this.comboBoxMonthEnd.Location = new System.Drawing.Point(466, 411);
            this.comboBoxMonthEnd.Name = "comboBoxMonthEnd";
            this.comboBoxMonthEnd.Size = new System.Drawing.Size(175, 31);
            this.comboBoxMonthEnd.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonSave.Location = new System.Drawing.Point(671, 453);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 38);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "S A V E";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // numericUpDownYearStart
            // 
            this.numericUpDownYearStart.Font = new System.Drawing.Font("Arial", 12F);
            this.numericUpDownYearStart.Location = new System.Drawing.Point(671, 345);
            this.numericUpDownYearStart.Name = "numericUpDownYearStart";
            this.numericUpDownYearStart.Size = new System.Drawing.Size(175, 30);
            this.numericUpDownYearStart.TabIndex = 11;
            // 
            // numericUpDownYearEnd
            // 
            this.numericUpDownYearEnd.Font = new System.Drawing.Font("Arial", 12F);
            this.numericUpDownYearEnd.Location = new System.Drawing.Point(671, 411);
            this.numericUpDownYearEnd.Name = "numericUpDownYearEnd";
            this.numericUpDownYearEnd.Size = new System.Drawing.Size(175, 30);
            this.numericUpDownYearEnd.TabIndex = 12;
            // 
            // FormKisahHidup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.Kisah_Hidup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.numericUpDownYearEnd);
            this.Controls.Add(this.numericUpDownYearStart);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxMonthEnd);
            this.Controls.Add(this.comboBoxMonthStart);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.textBoxInstitutionName);
            this.Controls.Add(this.comboBoxInstitution);
            this.Name = "FormKisahHidup";
            this.Text = "FormKisahHidup";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInstitution;
        private System.Windows.Forms.TextBox textBoxInstitutionName;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.ComboBox comboBoxMonthStart;
        private System.Windows.Forms.ComboBox comboBoxMonthEnd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownYearStart;
        private System.Windows.Forms.NumericUpDown numericUpDownYearEnd;
    }
}