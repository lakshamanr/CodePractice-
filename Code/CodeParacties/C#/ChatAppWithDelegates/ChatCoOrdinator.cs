using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAppWithDelegates
{
    public delegate void BroadCastMessageHandler(string astrMessage);
    public class ChatCoordinator
    {
        //List<BroadCastMessageHandler> _lstBroadCastMessages = new List<BroadCastMessageHandler>();
       public event BroadCastMessageHandler RecivedMessage;
       private static ChatCoordinator lobjChatCoordinator { get; set; }

       private ChatCoordinator()
       {
       }
         

       public void BroadCast(string astrMessages)
       {
            //Raise the events
            if (RecivedMessage != null)
            {
                RecivedMessage(astrMessages);
            }
       }

       public static ChatCoordinator Instance
       {
           get
           {
               if (lobjChatCoordinator == null)
               {
                   lobjChatCoordinator = new ChatCoordinator();
               } 
               return lobjChatCoordinator;
           }
       }
    }
}
