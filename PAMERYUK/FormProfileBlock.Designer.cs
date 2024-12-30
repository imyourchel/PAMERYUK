namespace PAMERYUK
{
    partial class FormProfileBlock
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
            this.labelPost = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonUnblock = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(673, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "0000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // labelPost
            // 
            this.labelPost.BackColor = System.Drawing.Color.Transparent;
            this.labelPost.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.labelPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.labelPost.Location = new System.Drawing.Point(490, 34);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(75, 30);
            this.labelPost.TabIndex = 41;
            this.labelPost.Text = "0000";
            this.labelPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.labelName.Location = new System.Drawing.Point(247, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 23);
            this.labelName.TabIndex = 40;
            this.labelName.Text = "Rachel R. A.";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.labelUsername.Location = new System.Drawing.Point(246, 34);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(222, 29);
            this.labelUsername.TabIndex = 39;
            this.labelUsername.Text = "@rachel_rosalind";
            // 
            // buttonUnblock
            // 
            this.buttonUnblock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonUnblock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnblock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnblock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonUnblock.Location = new System.Drawing.Point(631, 113);
            this.buttonUnblock.Name = "buttonUnblock";
            this.buttonUnblock.Size = new System.Drawing.Size(168, 30);
            this.buttonUnblock.TabIndex = 38;
            this.buttonUnblock.Text = "Unblock";
            this.buttonUnblock.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.Location = new System.Drawing.Point(95, 29);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(135, 135);
            this.pictureBoxProfile.TabIndex = 37;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormProfileBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.Other_User_Page_kosong;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonUnblock);
            this.Controls.Add(this.pictureBoxProfile);
            this.DoubleBuffered = true;
            this.Name = "FormProfileBlock";
            this.Text = "FormProfileBlock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonUnblock;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}