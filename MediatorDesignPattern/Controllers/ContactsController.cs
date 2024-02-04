using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorDesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IMediator mediator;
        public ContactsController(IMediator mediator) => this.mediator = mediator;
        [HttpGet("{id}")]
        public async Task<Contact> GetContact([FromRoute] Query query) => await this.mediator.Send(query);

    }
}
