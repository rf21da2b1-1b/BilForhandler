using BilForhandlerRest.Managers;
using BilModelLib.model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BilForhandlerRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilerController : ControllerBase
    {
        // brug manager
        private IBilManager mgr = new BilManager();

        // GET: api/<BilerController>
        [HttpGet]
        public IEnumerable<Bil> Get()
        {
            return mgr.Get();
        }

        // GET api/<BilerController>/5
        [HttpGet("{stelnummer}")]
        public Bil Get(String stelnummer)
        {
            return mgr.Get(stelnummer);
        }

        // POST api/<BilerController>
        [HttpPost]
        public Bil Post([FromBody] Bil bil)
        {
            return mgr.Create(bil);
        }

        // PUT api/<BilerController>/5
        [HttpPut("{stelnummer}")]
        public Bil Put(string stelnummer, [FromBody] Bil bil)
        {
            return mgr.Update(stelnummer, bil);
        }

        // DELETE api/<BilerController>/5
        [HttpDelete("{stelnummer}")]
        //[EnableCors("OnlyGetDelete")]
        public Bil Delete(string stelnummer)
        {
            return mgr.Delete(stelnummer);
        }
    }
}
