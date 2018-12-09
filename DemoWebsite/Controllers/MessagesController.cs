using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebsite.Models;
using DemoWebsite.Globals;

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
            List<Message> model = null;
            if(id == 1)
            {
                model = TEMPDATA.SALLYCONVERSATION;
            }
            else if(id == 2)
            {
                model = TEMPDATA.JOHNCONVERSATION;
            }
            else if (id == 3)
            {
                model = TEMPDATA.AUSTINCONVERSATION;
            }
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
                Sender = SessionVariables.CurrentUser
            });
        }
    }
}