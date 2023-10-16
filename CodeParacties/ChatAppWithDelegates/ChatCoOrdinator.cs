using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAppWithDelegates
{
    public delegate void BroadCastMessageHandler(string astrMessage);
    public class ChatCoordinator
    {
       List<BroadCastMessageHandler> _lstBroadCastMessages = new List<BroadCastMessageHandler>();
       private static ChatCoordinator lobjChatCoordinator { get; set; }

       private ChatCoordinator()
       {
       }

       public void Register(BroadCastMessageHandler aobjMessageHandler)
       {
           _lstBroadCastMessages.Add(aobjMessageHandler);
       }

       public void BroadCast(string astrMessages)
       {
           foreach (BroadCastMessageHandler BroadCastMessageHandler in _lstBroadCastMessages)
           {
               BroadCastMessageHandler(astrMessages);
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
