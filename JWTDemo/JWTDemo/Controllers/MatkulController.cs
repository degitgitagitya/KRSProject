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
    [Route("api/Matkul")]
    public class MatkulController : Controller
    {
        // GET: api/Matkul
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            MatkulRepo matkul = new MatkulRepo();
            var listMatkul = matkul.getAll();

            if (listMatkul == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listMatkul);
            }
        }

        // GET: api/Matkul/5
        [HttpGet("GetBy/{id}", Name = "GetMatkul")]
        public IActionResult Get(int id)
        {
            MatkulRepo matkul = new MatkulRepo();
            var hasil = matkul.getById(id);

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

        // POST: api/Matkul
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Matkul value)
        {
            MatkulRepo matkul = new MatkulRepo();
            var feedback = matkul.insert(value);
            return Ok(feedback);
        }

        // PUT: api/Matkul/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Matkul value)
        {
            MatkulRepo matkul = new MatkulRepo();
            if (matkul.update(value) == true)
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
            MatkulRepo matkul = new MatkulRepo();
            Matkul mat = new Matkul();
            mat.Id = id;
            if (matkul.delete(mat) == true)
            {
                return Ok(mat);
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
