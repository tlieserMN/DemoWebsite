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
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Message> messages;
            using (HomeDbContext dbContext = new HomeDbContext())
            {
                messages = dbContext.HomeMessages.SqlQuery("EXEC GetHomeMessages @UserID", new SqlParameter("UserID", SessionVariables.CurrentUserID)).ToList();
            }
            return View("Home", messages);
        }

        [HttpPost]
        public void AddHomeMessage(string header, string body)
        {
            using (HomeDbContext dbContext = new HomeDbContext())
            {
                int result = dbContext.Database.ExecuteSqlCommand("EXEC AddMessage @UserID, @Header, @Body, @ReceiverID=NULL", 
                    new SqlParameter("UserID", SessionVariables.CurrentUserID), 
                    new SqlParameter("Header", header), 
                    new SqlParameter("Body", body));
            }
        }
    }
}