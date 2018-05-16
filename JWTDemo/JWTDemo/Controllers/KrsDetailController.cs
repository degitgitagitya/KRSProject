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
    [Route("api/KrsDetail")]
    public class KrsDetailController : Controller
    {
        // GET: api/KrsDetail
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            KrsDetailRepo krsDetail = new KrsDetailRepo();
            var listKrsDetail = krsDetail.getAll();

            if (listKrsDetail == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listKrsDetail);
            }
        }

        // GET: api/KrsDetail/5
        [HttpGet("GetBy/{id}", Name = "GetKrsDetail")]
        public IActionResult Get(int id)
        {
            KrsDetailRepo krs = new KrsDetailRepo();
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

        // POST: api/KrsDetail
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]KrsDetail value)
        {
            KrsDetailRepo krsDetail = new KrsDetailRepo();
            var feedback = krsDetail.insert(value);
            return Ok(feedback);
        }

        // PUT: api/KrsDetail/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]KrsDetail value)
        {
            KrsDetailRepo krs = new KrsDetailRepo();
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
            KrsDetailRepo krs = new KrsDetailRepo();
            KrsDetail kr = new KrsDetail();
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
