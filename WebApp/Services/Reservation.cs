using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Services
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin || MadeBy == user)
                return true;

            return false;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}