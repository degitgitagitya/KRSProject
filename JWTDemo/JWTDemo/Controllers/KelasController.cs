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
    [Produces("application/json")]
    [Authorize]
    [Route("api/Kelas")]
    public class KelasController : Controller
    {
        // GET: api/Kelas
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            KelasRepo kelas = new KelasRepo();
            var listKelas  = kelas.getAll();

            if (listKelas == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listKelas);
            }
        }

        // GET: api/Kelas/5
        [HttpGet("GetBy/{id}", Name = "GetKelas")]
        public IActionResult Get(int id)
        {
            KelasRepo kelas = new KelasRepo();
            var hasil = kelas.getById(id);

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

        // POST: api/Kelas
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Kelas value)
        {
            KelasRepo kelas = new KelasRepo();
            var feedback = kelas.insert(value);
            return Ok(feedback);
        }
        
        // PUT: api/Kelas/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Kelas value)
        {
            KelasRepo kelas = new KelasRepo();
            if (kelas.update(value) == true)
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
            KelasRepo kelas = new KelasRepo();
            Kelas kel = new Kelas();
            kel.Id = id;
            if (kelas.delete(kel) == true)
            {
                return Ok(kel);
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
