using System.Collections.Generic;
using System.Linq;

using Railway.Models.Entities;
using Railway.Models.Interfaces;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Railway.Controllers
{
    [Route("api/carriage")]
    [ApiController]
    public class CarriageController : ControllerBase
    {
        readonly IService<Carriage> service;

        public CarriageController(IService<Carriage> service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<Carriage> Get()
        {
            return service
                .GetQuery()
                .ToList();
        }

        [HttpGet("{id}")]
        public Carriage Get(int id)
        {
            return service.FindById(id);
        }

        [HttpPost("save")]
        public List<Carriage> Post([FromBody] Carriage value)
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
