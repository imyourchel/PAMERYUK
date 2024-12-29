namespace PAMERYUK
{
    partial class FormEditProfile
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
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxIDNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pictureBoxProfilePict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePict)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxFullName.Location = new System.Drawing.Point(321, 208);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(400, 27);
            this.textBoxFullName.TabIndex = 1;
            // 
            // textBoxIDNumber
            // 
            this.textBoxIDNumber.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxIDNumber.Location = new System.Drawing.Point(321, 264);
            this.textBoxIDNumber.Name = "textBoxIDNumber";
            this.textBoxIDNumber.Size = new System.Drawing.Size(180, 27);
            this.textBoxIDNumber.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox1.Location = new System.Drawing.Point(321, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxUsername.Location = new System.Drawing.Point(541, 264);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(180, 27);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(321, 324);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 27);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoPassword
            // 
            this.textBoPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoPassword.Location = new System.Drawing.Point(541, 324);
            this.textBoPassword.Name = "textBoPassword";
            this.textBoPassword.Size = new System.Drawing.Size(180, 27);
            this.textBoPassword.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonLogin.Location = new System.Drawing.Point(166, 397);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(565, 38);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "S A V E";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegister.Font = new System.Drawing.Font("Arial", 8F);
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonRegister.Location = new System.Drawing.Point(166, 318);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(135, 33);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Change Picture";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfilePict
            // 
            this.pictureBoxProfilePict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.pictureBoxProfilePict.BackgroundImage = global::PAMERYUK.Properties.Resources.@__2_;
            this.pictureBoxProfilePict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilePict.Location = new System.Drawing.Point(166, 177);
            this.pictureBoxProfilePict.Name = "pictureBoxProfilePict";
            this.pictureBoxProfilePict.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxProfilePict.TabIndex = 11;
            this.pictureBoxProfilePict.TabStop = false;
            // 
            // FormEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.EDIT_PROFILE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.pictureBoxProfilePict);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxIDNumber);
            this.Controls.Add(this.textBoxFullName);
            this.Name = "FormEditProfile";
            this.Text = "FormEditProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pictureBoxProfilePict;
    }
}