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
    [Route("api/Mhs")]
    public class MhsController : Controller
    {
        // GET: api/Mhs
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            MhsRepo mhs = new MhsRepo();
            var listMhs = mhs.getAll();

            if (listMhs == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listMhs);
            }
        }

        // GET: api/Mhs/5
        [HttpGet("GetBy/{id}", Name = "GetMhs")]
        public IActionResult Get(int id)
        {
            MhsRepo mhs = new MhsRepo();
            var hasil = mhs.getById(id);

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

        // POST: api/Mhs
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Mhs value)
        {
            MhsRepo mhs = new MhsRepo();
            var feedback = mhs.insert(value);
            return Ok(feedback);
        }

        // PUT: api/Mhs/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Mhs value)
        {
            MhsRepo mhs = new MhsRepo();
            if (mhs.update(value) == true)
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
            MhsRepo mhs = new MhsRepo();
            Mhs mh = new Mhs();
            mh.Id = id;
            if (mhs.delete(mh) == true)
            {
                return Ok(mh);
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
