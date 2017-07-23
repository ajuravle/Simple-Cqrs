using CQRS_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Project.Cqrs.Comands
{
    class UpdateComand
    {
        public UpdateComand(User user)
        {
            User = user;
        }

        public User User { get; private set; }
    }
}
