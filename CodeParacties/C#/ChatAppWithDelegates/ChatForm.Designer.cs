namespace ChatAppWithDelegates
{
    partial class ChatForm
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
            this.txtSendMessageBox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageBord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSendMessageBox
            // 
            this.txtSendMessageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSendMessageBox.Location = new System.Drawing.Point(26, 383);
            this.txtSendMessageBox.Multiline = true;
            this.txtSendMessageBox.Name = "txtSendMessageBox";
            this.txtSendMessageBox.Size = new System.Drawing.Size(365, 54);
            this.txtSendMessageBox.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(397, 398);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 27);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageBord
            // 
            this.txtMessageBord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageBord.Location = new System.Drawing.Point(50, 36);
            this.txtMessageBord.Multiline = true;
            this.txtMessageBord.Name = "txtMessageBord";
            this.txtMessageBord.Size = new System.Drawing.Size(341, 271);
            this.txtMessageBord.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 449);
            this.Controls.Add(this.txtMessageBord);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMessageBox);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSendMessageBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageBord;
    }
}