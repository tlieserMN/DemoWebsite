using DemoWebsite.Globals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebsite.Controllers
{
    public class AccountController : Controller
    {
        //GET: Account
        public ActionResult Account()
        {
            User user;
            using (UsersDbContext dbContext = new UsersDbContext())
            {
                user = dbContext.Account.SqlQuery("EXEC GetUser @UserID", new SqlParameter("UserID", SessionVariables.CurrentUserID)).ToList().ElementAt(0);
            }
            return View("Account", user);
        }

        [HttpPost]
        public void UpdateAccount(string aboutme, string firstname, string lastname, string email, string birthday, int age)
        {
            using (UsersDbContext dbContext = new UsersDbContext())
            {
                int result = dbContext.Database.ExecuteSqlCommand("EXEC UpdateUser @UserID, @FirstName, @LastName, @Email, @Birthday, @Age, @AboutMe", 
                    new SqlParameter("UserID", SessionVariables.CurrentUserID), 
                    new SqlParameter("FirstName", firstname), 
                    new SqlParameter("LastName", lastname), 
                    new SqlParameter("Email", email),
                    new SqlParameter("Birthday", birthday),
                    new SqlParameter("Age", age), 
                    new SqlParameter("AboutMe", aboutme));
            }
        }
    }
}