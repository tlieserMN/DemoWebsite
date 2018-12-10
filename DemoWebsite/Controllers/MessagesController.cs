using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebsite.Models;

namespace DemoWebsite.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult Messages()
        {
            return View("Messages", TEMPDATA.MESSAGES);
        }
        
        public ActionResult GetConversation(int id)
        {
            List<Message> messages = null;
            if(id == 1)
            {
                messages = TEMPDATA.SALLYCONVERSATION;
            }
            else if(id == 2)
            {
                messages = TEMPDATA.JOHNCONVERSATION;
            }
            else if (id == 3)
            {
                messages = TEMPDATA.AUSTINCONVERSATION;
            }
            ConversationModel model = new ConversationModel
            {
                ReceiverID = id,
                Messages = messages
            };
            return View("Conversation", model);
        }

        [HttpPost]
        public void AddMessage(string header, string body)
        {
            TEMPDATA.HOME.Messages.Insert(0, new Message
            {
                ID = 2,
                Header = header,
                Body = body,
                Sender = TEMPDATA.LOGEDINUSER.FirstName + " " + TEMPDATA.LOGEDINUSER.LastName
            });
        }

        [HttpPost]
        public void AddPrivateMessage(string header, string body, int receiver_id)
        {
            List<Message> conversation = null;
            if (receiver_id == 1)
            {
                conversation = TEMPDATA.SALLYCONVERSATION;
            }
            else if (receiver_id == 2)
            {
                conversation = TEMPDATA.JOHNCONVERSATION;
            }
            else if (receiver_id == 3)
            {
                conversation = TEMPDATA.AUSTINCONVERSATION;
            }

            if (conversation != null)
            {
                conversation.Add(new Message
                {
                    ID = 2,
                    Header = header,
                    Body = body,
                    Sender = TEMPDATA.LOGEDINUSER.FirstName + " " + TEMPDATA.LOGEDINUSER.LastName
                });
            }
        }
    }
}