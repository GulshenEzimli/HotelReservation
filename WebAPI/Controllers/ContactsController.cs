using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            this._contactService = contactService;
        }
        [HttpPost("add")]
        public IActionResult Add(Contact contact)
        {
            var result = this._contactService.Add(contact);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update(Contact contact)
        {
            var result = this._contactService.Update(contact);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Contact contact)
        {
            var result = this._contactService.Delete(contact);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getall")]
        public IActionResult GetAll(Expression<Func<Contact, bool>>? filter)
        {
            var result = this._contactService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getdetails")]
        public IActionResult GetContactDetails()
        {
            var result = this._contactService.GetContactDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Contact, bool>> filter)
        {
            var result = this._contactService.Get(filter);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
