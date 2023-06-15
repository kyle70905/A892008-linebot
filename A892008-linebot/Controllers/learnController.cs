using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A892008_linebot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class learnController : ControllerBase
    {
        // GET: api/learn
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/learn/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/learn
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/learn/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/learn/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
