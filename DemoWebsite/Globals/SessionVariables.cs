using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebsite.Globals
{
    public static class SessionVariables
    {
        public static string CurrentUser = TEMPDATA.LOGEDINUSER.FirstName + " " + TEMPDATA.LOGEDINUSER.LastName;
        public static int CurrentUserID = TEMPDATA.LOGEDINUSER.ID;
    }
}