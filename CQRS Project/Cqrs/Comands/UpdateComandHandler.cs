using CQRS_Project.Data;
using CQRS_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Project.Cqrs.Comands
{
    class UpdateComandHandler
    {
        private MyDbContext _context;

        public UpdateComandHandler()
        {
            _context = new MyDbContext();
        }

        public void Execute(AddComand comand)
        {
            _context.Users.Update(comand.User);
            _context.SaveChanges();
        }
    }
}
