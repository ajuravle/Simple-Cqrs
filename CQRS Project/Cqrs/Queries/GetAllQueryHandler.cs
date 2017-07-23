using CQRS_Project.Data;
using CQRS_Project.Models;

namespace CQRS_Project.Cqrs.Comands.Queries
{
    class GetAllQueryHandler
    {
        private MyDbContext _context;

        public GetAllQueryHandler()
        {
            _context = new MyDbContext();
        }

        public GetAllQueryResult Execute(GetAllQuery query)
        {
            return new GetAllQueryResult(_context.Users);
        }
    }
}
