using CQRS_Project.Data;
using CQRS_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Project.Cqrs.Comands
{
    public class AddComandHandler
    {
        private MyDbContext _context;

        public AddComandHandler()
        {
            _context = new MyDbContext();
        }

        public void Execute(AddComand comand)
        {
            _context.Users.Add(comand.User);
            _context.SaveChanges();
        }
    }
}
