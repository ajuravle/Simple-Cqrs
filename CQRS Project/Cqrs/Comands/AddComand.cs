using CQRS_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Project.Cqrs.Comands
{
    public class AddComand
    {
        public AddComand(User user)
        {
            User = user;
        }

        public User User { get; private set; }
    }
}
