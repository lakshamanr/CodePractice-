using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatAppWithDelegates
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewChatWindow_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.Show();
        }

    }
}
