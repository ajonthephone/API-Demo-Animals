using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test : ControllerBase
    {
        // GET: api/<Test>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] animals = { "Lion", "Tiger", "Elephant" };
            // Create a List and add a collection  
            List<string> animalsList = new List<string>();
            animalsList.AddRange(animals);
            foreach (string a in animalsList)
            { return animalsList; }
            
            return default;
        }
        
        // GET api/<Test>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Test>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Test>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Test>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
