using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Railway.Models.Entities;
using Railway.Models.Interfaces;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace Railway.Controllers
{
    [Route("api/train")]
    [ApiController]
    public class TrainController : ControllerBase 
    {
        readonly IService<Train> service;

        public TrainController(IService<Train> service)
        {
            this.service = service;
        }

        [HttpGet]
        public List<Train> Get()
        {
            return service
                .GetQuery()
                .ToList();
        }

        [HttpGet("{id}")]
        public Train Get(int id)
        {
            return service.FindById(id);
        }

        [HttpPost("save")]
        public List<Train> Post([FromBody] Train value)
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
