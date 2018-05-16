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
    [Route("api/Dosen")]
    public class DosenController : Controller
    {
        // GET: api/Dosen
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            DosenRepo dosen = new DosenRepo();
            var listDosen = dosen.getAll();

            if (listDosen == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listDosen);
            }
        }

        // GET: api/Dosen/5
        [HttpGet("GetBy/{id}", Name = "GetDosen")]
        public IActionResult Get(int id)
        {
            DosenRepo dosen = new DosenRepo();
            var hasil = dosen.getById(id);

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
        
        // POST: api/Dosen
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Dosen value)
        {
            DosenRepo dosen = new DosenRepo();
            var temp = dosen.insert(value);
            return Ok(temp);
        }
        
        // PUT: api/Dosen/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Dosen value)
        {
            DosenRepo dosen = new DosenRepo();
            if (dosen.update(value) == true)
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
            DosenRepo dosen = new DosenRepo();
            Dosen dos = new Dosen();
            dos.Id = id;
            if (dosen.delete(dos) == true)
            {
                return Ok(dos);
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
