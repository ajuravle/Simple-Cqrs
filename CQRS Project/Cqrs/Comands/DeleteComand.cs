using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Project.Cqrs.Comands
{
    class DeleteComand
    {
        public DeleteComand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
