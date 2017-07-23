using CQRS_Project.Cqrs.Comands;
using CQRS_Project.Cqrs.Comands.Queries;
using CQRS_Project.Models;
using System;

namespace CQRS_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            AddComandHandler addComand = new AddComandHandler();
            addComand.Execute(new AddComand(new Models.User { Id = Guid.NewGuid(), Username = "username3", Password = "parola3" }));

            GetAllQueryHandler getAll = new GetAllQueryHandler();

            foreach(User user in getAll.Execute(new GetAllQuery()).Users)
            {
                Console.WriteLine(user.Username + " - " + user.Password);
            }

            Console.ReadKey();
        }
    }
}