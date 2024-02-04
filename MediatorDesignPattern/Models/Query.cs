using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorDesignPattern.Models
{
    public class Query : IRequest<Contact>
    {
        public int Id { get; set; }
    }

    public class ContactHandler : IRequestHandler<Query, Contact>
    {
        private ContactsContext db;
        public ContactHandler(ContactsContext db) => this.db = db;
        public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return await this.db.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
        }
    }
}
