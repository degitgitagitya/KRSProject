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
    [Route("api/DaftarJadwal")]
    public class DaftarJadwalController : Controller
    {
        // GET: api/DaftarJadwal/GetAll
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            DaftarjadwalRepo lstjad = new DaftarjadwalRepo();
            var listJadwals = lstjad.getAll();

            if (listJadwals == null)
            {
                var response = new ContentResult()
                {
                    StatusCode = StatusCodes.Status204NoContent,
                };
                return response;
            }
            else
            {
                return Ok(listJadwals);
            }
        }
    }
}