using MediatR;

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
        public Task<Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return this.db.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
        }
    }
}
