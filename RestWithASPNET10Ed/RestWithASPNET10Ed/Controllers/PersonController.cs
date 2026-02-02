using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Ed.Services;
using RestWithASPNET10Ed.Model;

namespace RestWithASPNET10Ed.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonServices _personServices;

        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id) 
        { 
            var person = _personServices.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var createPerson = _personServices.Create(person);
            if (createPerson == null) return NotFound();
            return Ok(createPerson);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            var createPerson = _personServices.Update(person);
            if (createPerson == null) return NotFound();
            return Ok(createPerson);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personServices.Delete(id);
            return NoContent();
        }
    }
}
