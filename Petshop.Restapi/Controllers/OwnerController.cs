using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petshop.Core.ApplicationService;
using Petshop.Core.Entity;

namespace Petshop.Restapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {


        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;


        }

        public ActionResult<IEnumerable<Owner>> Get()
        {
            return _ownerService.GetAllOwners();


        }

        // GET: api/Owner/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult <Owner> Get(int id)
        {
            return _ownerService.SortById(id);
        }

        // POST: api/Owner
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
            if (string.IsNullOrEmpty(owner.FirstName))
            {
                return BadRequest("A name is required for creating an owner");
            }

            return _ownerService.CreateOwner(owner);
        }

        // PUT: api/Owner/5
        public ActionResult Put(int id, [FromBody] Owner owner)
        {
            if (id < 1 || id != owner.id)
            {
                return BadRequest("Parameter Id and Owner Id must be identical");
            }

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            _ownerService.DeleteOwner(id);
            return Ok("Everything works");
        }
    }
}
