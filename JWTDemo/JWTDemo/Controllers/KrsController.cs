using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTDemo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTDemo.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Krs")]
    public class KrsController : Controller
    {
        // GET: api/Krs
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            KrsRepo krs = new KrsRepo();
            var listKrs = krs.getAll();

            if (listKrs == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listKrs);
            }
        }

        // GET: api/Krs/5
        [HttpGet("GetBy/{id}", Name = "GetKrs")]
        public IActionResult Get(int id)
        {
            KrsRepo krs = new KrsRepo();
            var hasil = krs.getById(id);

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

        // POST: api/Krs
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Krs value)
        {
            KrsRepo krs = new KrsRepo();
            var feedback = krs.insert(value);
            return Ok(feedback);
        }

        // PUT: api/Krs/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Krs value)
        {
            KrsRepo krs = new KrsRepo();
            if (krs.update(value) == true)
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
            KrsRepo krs = new KrsRepo();
            Krs kr = new Krs();
            kr.Id = id;
            if (krs.delete(kr) == true)
            {
                return Ok(kr);
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
