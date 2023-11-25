using System;
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
            _chatCoordinator.RecivedMessage += ReceiveMessage;
        }
        private void ReceiveMessage(string astrMessage)
        {
            txtMessageBord.Text += astrMessage + Environment.NewLine;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _chatCoordinator.BroadCast(txtSendMessageBox.Text);
        }
    }
}
