namespace PAMERYUK
{
    partial class FormRegister
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxIDNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBoxIDPict = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIDPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePict)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonRegister.Location = new System.Drawing.Point(79, 383);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(740, 38);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "R E G I S T E R";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 8F);
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonLogin.Location = new System.Drawing.Point(692, 438);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(127, 33);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxFullName.Location = new System.Drawing.Point(78, 226);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(400, 27);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxIDNumber
            // 
            this.textBoxIDNumber.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxIDNumber.Location = new System.Drawing.Point(78, 281);
            this.textBoxIDNumber.Name = "textBoxIDNumber";
            this.textBoxIDNumber.Size = new System.Drawing.Size(182, 27);
            this.textBoxIDNumber.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(78, 339);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(182, 27);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(296, 281);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(182, 27);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxPassword.Location = new System.Drawing.Point(296, 339);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(182, 27);
            this.textBoxPassword.TabIndex = 5;
            // 
            // pictureBoxIDPict
            // 
            this.pictureBoxIDPict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.pictureBoxIDPict.BackgroundImage = global::PAMERYUK.Properties.Resources.@__2_;
            this.pictureBoxIDPict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIDPict.Location = new System.Drawing.Point(518, 230);
            this.pictureBoxIDPict.Name = "pictureBoxIDPict";
            this.pictureBoxIDPict.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxIDPict.TabIndex = 10;
            this.pictureBoxIDPict.TabStop = false;
            // 
            // pictureBoxProfilePict
            // 
            this.pictureBoxProfilePict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.pictureBoxProfilePict.BackgroundImage = global::PAMERYUK.Properties.Resources.@__2_;
            this.pictureBoxProfilePict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilePict.Location = new System.Drawing.Point(684, 230);
            this.pictureBoxProfilePict.Name = "pictureBoxProfilePict";
            this.pictureBoxProfilePict.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxProfilePict.TabIndex = 11;
            this.pictureBoxProfilePict.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.REGISTER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.pictureBoxProfilePict);
            this.Controls.Add(this.pictureBoxIDPict);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxIDNumber);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIDPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxIDPict;
        private System.Windows.Forms.PictureBox pictureBoxProfilePict;
    }
}