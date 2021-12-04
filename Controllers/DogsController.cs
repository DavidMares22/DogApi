using DogApi.Data;
using DogApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> GetDogs()
        {
            try
            {
                var Dogs = await _dbContext.Dogs.ToListAsync();
                return Ok(Dogs);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please try again later");
            }
        }

        // GET api/<DogsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DogsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Dog dog)
        {
            try
            {

           
                // Add custom model validation error
                var repeatedDog = await _dbContext.Dogs.FirstOrDefaultAsync<Dog>(e => dog.Name == e.Name);

                if (repeatedDog != null)
                {
                    ModelState.AddModelError("Name", "Dog Name already in exists");
                    return BadRequest(ModelState);
                }

               await _dbContext.Dogs.AddAsync(dog);
                await _dbContext.SaveChangesAsync();
                return StatusCode(201);
    
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please try again later");
            }
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
