using CQRS_Project.Models;
using System.Collections.Generic;

namespace CQRS_Project.Cqrs.Comands.Queries
{
    class GetAllQueryResult
    {
        public GetAllQueryResult(IEnumerable<User> users)
        {
            Users = users;
        }

        public IEnumerable<User> Users { get; private set; }
    }
}
