namespace ChatAppWithDelegates
{
    partial class MainForm
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
            this.btnCreateNewChatWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewChatWindow
            // 
            this.btnCreateNewChatWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateNewChatWindow.Location = new System.Drawing.Point(12, 12);
            this.btnCreateNewChatWindow.Name = "btnCreateNewChatWindow";
            this.btnCreateNewChatWindow.Size = new System.Drawing.Size(442, 47);
            this.btnCreateNewChatWindow.TabIndex = 0;
            this.btnCreateNewChatWindow.Text = "New Chat Window";
            this.btnCreateNewChatWindow.UseVisualStyleBackColor = true;
            this.btnCreateNewChatWindow.Click += new System.EventHandler(this.btnCreateNewChatWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.btnCreateNewChatWindow);
            this.Name = "MainForm";
            this.Text = "Create New Chat Window ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewChatWindow;
    }
}

