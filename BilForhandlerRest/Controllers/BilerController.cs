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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            List<Bil> liste = mgr.Get();
            return (liste.Count == 0)?NoContent():Ok(liste);
        }

        

        // GET api/<BilerController>/5
        [HttpGet] // metode
        [Route("{stelnummer}")] // URI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(String stelnummer)
        {
            try
            {
                Bil bil = mgr.Get(stelnummer);
                return Ok(bil);
            }
            catch(KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        [HttpGet] // metode
        [Route("Model/{model}")] // URI
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetModel(String model)
        {
            List<Bil> biler = mgr.GetModel(model);

            return (biler.Count > 0)?Ok(biler):NoContent();   
        }


        [HttpGet]
        [Route("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get([FromQuery] BilYearFilter filter)
        {
            List<Bil> liste = mgr.SearchYear(filter.StartYear, filter.EndYear);
            return (liste.Count == 0) ? NoContent() : Ok(liste);
        }

        // POST api/<BilerController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]   
        public IActionResult Post([FromBody] Bil bil)
        {
            try
            {
                Bil nyBil = mgr.Create(bil);
                String uri = "api/Biler/" + bil.StelNummer;
                return Created(uri, bil);
            }
            catch(ArgumentException ae)
            {
                return Conflict(ae.Message);
            }

        }

        // PUT api/<BilerController>/5
        [HttpPut]
        [Route("{stelnummer}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(string stelnummer, [FromBody] Bil bil)
        {
            try
            {
                return Ok(mgr.Update(stelnummer, bil));
            }
            catch(KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }

        }

        // DELETE api/<BilerController>/5
        [HttpDelete]
        [Route("{stelnummer}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[EnableCors("OnlyGetDelete")]
        public IActionResult Delete(string stelnummer)
        {
            try
            {
                return Ok(mgr.Delete(stelnummer));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }
    }
}
