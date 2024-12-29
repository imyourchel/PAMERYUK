namespace PAMERYUK
{
    partial class FormOtherPost
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
            this.listBoxCaption = new System.Windows.Forms.ListBox();
            this.listBoxComment = new System.Windows.Forms.ListBox();
            this.buttonComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Location = new System.Drawing.Point(71, 160);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxPost.TabIndex = 0;
            this.pictureBoxPost.TabStop = false;
            // 
            // listBoxCaption
            // 
            this.listBoxCaption.Font = new System.Drawing.Font("Arial", 8F);
            this.listBoxCaption.FormattingEnabled = true;
            this.listBoxCaption.ItemHeight = 16;
            this.listBoxCaption.Location = new System.Drawing.Point(71, 408);
            this.listBoxCaption.Name = "listBoxCaption";
            this.listBoxCaption.Size = new System.Drawing.Size(240, 84);
            this.listBoxCaption.TabIndex = 2;
            // 
            // listBoxComment
            // 
            this.listBoxComment.Font = new System.Drawing.Font("Arial", 8F);
            this.listBoxComment.FormattingEnabled = true;
            this.listBoxComment.ItemHeight = 16;
            this.listBoxComment.Location = new System.Drawing.Point(367, 187);
            this.listBoxComment.Name = "listBoxComment";
            this.listBoxComment.Size = new System.Drawing.Size(457, 260);
            this.listBoxComment.TabIndex = 3;
            // 
            // buttonComment
            // 
            this.buttonComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComment.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.buttonComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(206)))));
            this.buttonComment.Location = new System.Drawing.Point(658, 456);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(166, 36);
            this.buttonComment.TabIndex = 11;
            this.buttonComment.Text = "COMMENT";
            this.buttonComment.UseVisualStyleBackColor = false;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxComment.Location = new System.Drawing.Point(367, 459);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(285, 27);
            this.textBoxComment.TabIndex = 12;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelUsername.Location = new System.Drawing.Point(71, 126);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(229, 24);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "@rachel_rosalind0410";
            // 
            // FormOtherPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PAMERYUK.Properties.Resources.POSTINGAN_ORG_LAIN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.listBoxComment);
            this.Controls.Add(this.listBoxCaption);
            this.Controls.Add(this.pictureBoxPost);
            this.Name = "FormOtherPost";
            this.Text = "FormOtherPost";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.ListBox listBoxCaption;
        private System.Windows.Forms.ListBox listBoxComment;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelUsername;
    }
}