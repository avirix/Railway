using System.Collections.Generic;
using System.Linq;

using Railway.Models.Entities;
using Railway.Models.Interfaces;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Railway.Controllers
{
    [Route("api/station")]
    [ApiController]
    public class StationController : ControllerBase
    {
        readonly IService<Station> service;

        public StationController(IService<Station> service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<Station> Get()
        {
            return service
                .GetQuery()
                .ToList();
        }

        [HttpGet("{id}")]
        public Station Get(int id)
        {
            return service.FindById(id);
        }

        [HttpPost("save")]
        public List<Station> Post([FromBody] Station value)
        {
            service.Create(value);
            return service
                .GetAll()
                .Where(x => x.Id == value.Id)
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
