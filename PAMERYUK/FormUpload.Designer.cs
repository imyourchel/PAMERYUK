namespace PAMERYUK
{
    partial class FormUpload
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
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.listBoxCaption = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Location = new System.Drawing.Point(71, 179);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(278, 278);
            this.pictureBoxPost.TabIndex = 1;
            this.pictureBoxPost.TabStop = false;
            // 
            // buttonTag
            // 
            this.buttonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTag.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonTag.Location = new System.Drawing.Point(366, 427);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(167, 30);
            this.buttonTag.TabIndex = 8;
            this.buttonTag.Text = "T A G";
            this.buttonTag.UseVisualStyleBackColor = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpload.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonUpload.Location = new System.Drawing.Point(657, 427);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(167, 30);
            this.buttonUpload.TabIndex = 9;
            this.buttonUpload.Text = "U P L O A D";
            this.buttonUpload.UseVisualStyleBackColor = false;
            // 
            // listBoxCaption
            // 
            this.listBoxCaption.Font = new System.Drawing.Font("Arial", 10F);
            this.listBoxCaption.FormattingEnabled = true;
            this.listBoxCaption.ItemHeight = 19;
            this.listBoxCaption.Location = new System.Drawing.Point(366, 209);
            this.listBoxCaption.Name = "listBoxCaption";
            this.listBoxCaption.Size = new System.Drawing.Size(458, 194);
            this.listBoxCaption.TabIndex = 10;
            // 
            // FormUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.Upload;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.listBoxCaption);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.pictureBoxPost);
            this.Name = "FormUpload";
            this.Text = "FormUpload";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.ListBox listBoxCaption;
    }
}