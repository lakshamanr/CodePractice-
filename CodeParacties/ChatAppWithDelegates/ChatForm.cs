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
    public partial class ChatForm : Form
    {
        private ChatCoordinator _chatCoordinator = ChatCoordinator.Instance;
        public ChatForm()
        {
            InitializeComponent();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            BroadCastMessageHandler lobjCast = ReceiveMessage;
            _chatCoordinator.Register(lobjCast);
        }
        private void ReceiveMessage(string astrMessage)
        {
            txtMessageBord.Text += astrMessage+"\r\t";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _chatCoordinator.BroadCast(txtSendMessageBox.Text);
        }
    }
}
