using CQRS_Project.Data;
using CQRS_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Project.Cqrs.Comands
{
    class DeleteComandHandler
    {
        private MyDbContext _context;

        public DeleteComandHandler()
        {
            _context = new MyDbContext();
        }

        public void Execute(DeleteComand comand)
        {
            _context.Users.Remove(new User { Id = comand.Id });
            _context.SaveChanges();
        }
    }
}
