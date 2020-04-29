using System.Collections.Generic;
using System.Linq;

using Railway.Models.Entities;
using Railway.Models.Interfaces;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Railway.Controllers
{
    [Route("api/ticket")]
    [ApiController]
    public class TicketServiceController : ControllerBase
    {
        readonly IService<Ticket> service;

        public TicketServiceController(IService<Ticket> service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<Ticket> Get()
        {
            return service
                .GetQuery()
                .ToList();
        }

        [HttpGet("{id}")]
        public Ticket Get(int id)
        {
            return service.FindById(id);
        }

        [HttpPost("save")]
        public List<Ticket> Post([FromBody] Ticket value)
        {
            service.Create(value);
            return service
                .GetAll()
                .ToList();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
