using DogApi.Data;
using DogApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {

        private ApiDbContext _dbContext;

        public DogsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /dogs
        [HttpGet]
        public IEnumerable<Dog> Get()
        {
            return _dbContext.Dogs;
        }

        // GET api/<DogsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DogsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DogsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DogsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
