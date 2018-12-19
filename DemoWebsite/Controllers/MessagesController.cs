using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebsite.Globals;
using DemoWebsite.Models;

namespace DemoWebsite.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult Messages()
        {
            List<Friend> friends;
            using (MessagesDbContext dbContext = new MessagesDbContext())
            {
                friends = dbContext.Conversations.SqlQuery("EXEC GetConversationsWithFriends @UserID", new SqlParameter("UserID", SessionVariables.CurrentUserID)).ToList();
            }
            return View("Messages", friends);
        }

        public ActionResult GetConversation(int id)
        {
            List<Message> messages;
            using (MessagesDbContext dbContext = new MessagesDbContext())
            {
                messages = dbContext.ConversationMessages.SqlQuery("EXEC GetMessagesInConversation @UserID, @FriendID", 
                    new SqlParameter("UserID", SessionVariables.CurrentUserID), 
                    new SqlParameter("FriendID", id)).ToList();
            }

            Conversation con = new Conversation
            {
                Messages = messages,
                FriendID = id
            };
            return View("Conversation", con);
        }

        //[HttpPost]
        //public void AddMessage(string header, string body)
        //{
        //    TEMPDATA.HOME.Messages.Insert(0, new Message
        //    {
        //        ID = 2,
        //        Header = header,
        //        Body = body,
        //        Sender = TEMPDATA.LOGEDINUSER.FirstName + " " + TEMPDATA.LOGEDINUSER.LastName
        //    });
        //}

        [HttpPost]
        public void AddPrivateMessage(string header, string body, int friendid)
        {
            using (MessagesDbContext dbContext = new MessagesDbContext())
            {
                int result = dbContext.Database.ExecuteSqlCommand("EXEC AddMessage @UserID, @Header, @Body, @ReceiverID", 
                    new SqlParameter("UserID", SessionVariables.CurrentUserID), 
                    new SqlParameter("Header", header), new SqlParameter("Body", body), 
                    new SqlParameter("ReceiverID", friendid));
            }
        }
    }
}