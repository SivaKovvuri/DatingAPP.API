using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private DataContext _dataContext;
        public ValuesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [AllowAnonymous]
        // GET: api/Values
        [HttpGet]
        public async Task<ActionResult<Value>> Get()
        {
            IEnumerable<Value> values = await _dataContext.Values.ToListAsync();
            return Ok(values);

        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {

            var value = await _dataContext.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
