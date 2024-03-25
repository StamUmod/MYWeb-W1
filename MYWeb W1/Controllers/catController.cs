using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MYWeb_W1.Models;

namespace MYWeb_W1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class catController : ControllerBase
    {
        // GET: api/cat
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/cat/5
        [HttpGet("{cat}")]
        public catModels Get(string cat)
        {
            if (cat == "black")
            {
                return new catModels()
                {
                    id = 1234,
                    cat = "black cat",
                    Nurturing = false,
                };
            }
            
            return new  catModels();
        }

        // POST: api/cat
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/cat/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/cat/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
