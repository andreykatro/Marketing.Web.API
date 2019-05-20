using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marketing.Web.API.Interfaces;
using Marketing.Web.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Marketing.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        // GET: api/Contact
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contactRepository.GetAll());
        }

        // GET: api/Contact/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contact
        [HttpPost]
        public IActionResult Post([FromBody]Contact contact)
        {
            try
            {
                if (contact == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _contactRepository.Insert(contact);

            }
            catch (Exception)
            {
                return BadRequest();
            }
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_contactRepository.Delete(id));
        }
    }

    public class User
    {
        public string Name { set; get; }
    }
}
