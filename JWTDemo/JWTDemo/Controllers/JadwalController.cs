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
    [Route("api/Jadwal")]
    public class JadwalController : Controller
    {
        // GET: api/Jadwal
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            JadwalRepo jadwal = new JadwalRepo();
            var listJadwal = jadwal.getAll();

            if (listJadwal == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listJadwal);
            }
        }

        // GET: api/Jadwal/5
        [HttpGet("GetBy/{id}", Name = "GetJadwal")]
        public IActionResult Get(int id)
        {
            JadwalRepo jadwal = new JadwalRepo();
            var hasil = jadwal.getById(id);

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

        // POST: api/Jadwal
        [HttpPost("Insert")]
        public IActionResult Post([FromBody]Jadwal value)
        {
            JadwalRepo jadwal = new JadwalRepo();
            var feedback = jadwal.insert(value);
            return Ok(feedback);
        }

        // PUT: api/Jadwal/5
        [HttpPut("Update")]
        public IActionResult Put([FromBody]Jadwal value)
        {
            JadwalRepo jadwal = new JadwalRepo();
            if (jadwal.update(value) == true)
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
            JadwalRepo jadwal = new JadwalRepo();
            Jadwal jad = new Jadwal();
            jad.Id = id;
            if (jadwal.delete(jad) == true)
            {
                return Ok(jad);
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
