using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTDemo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Admin")]
    public class AdminController : Controller
    {
        // GET: api/Admin
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            AdminRepo admin = new AdminRepo();
            var listAdmin = admin.getAll();

            if (listAdmin == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listAdmin);
            }
        }

        // GET: api/Admin/5
        [HttpGet("GetBy/{id}", Name = "GetAdmin")]
        public IActionResult Get(int id)
        {
            AdminRepo admin = new AdminRepo();
            var hasil = admin.getById(id);

            if (hasil == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(hasil);
            }
        }

        // POST: api/Admin
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Admin value)
        {
            AdminRepo admin = new AdminRepo();
            var temp = admin.insert(value);
            return Ok(temp);


        }

        // PUT: api/Admin/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Admin value)
        {
            AdminRepo admin = new AdminRepo();
            if (admin.update(value) == true)
            {
                return Ok(value);
            }
            else
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status404NotFound,
                };
                return response;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            AdminRepo admin = new AdminRepo();
            Admin ad = new Admin();
            ad.Id = id;
            if (admin.delete(ad) == true)
            {
                return Ok(ad);
            }
            else
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status404NotFound,
                };
                return response;
            }
        }
    }
}