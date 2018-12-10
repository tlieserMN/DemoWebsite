using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebsite.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Account()
        {
            return View("Account", TEMPDATA.LOGEDINUSER);
        }

        [HttpPost]
        public void UpdateAccount(string aboutme, string firstname, string lastname, string email, string birthday, int age)
        {
            TEMPDATA.LOGEDINUSER.AboutMe = aboutme;
            TEMPDATA.LOGEDINUSER.FirstName = firstname;
            TEMPDATA.LOGEDINUSER.LastName = lastname;
            TEMPDATA.LOGEDINUSER.Email = email;
            TEMPDATA.LOGEDINUSER.Birthday = birthday;
            TEMPDATA.LOGEDINUSER.Age = age;
        }
    }
}