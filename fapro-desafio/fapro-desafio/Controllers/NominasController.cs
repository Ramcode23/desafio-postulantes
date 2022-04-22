using fapro_desafio.Models;
using fapro_desafio.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fapro_desafio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NominasController : ControllerBase
    {
        private readonly INominaService service;

        public NominasController(INominaService service)
        {
            this.service = service;
        }
        // GET: api/<NominasController>
        [HttpGet]
        public  IEnumerable<NominaRegistro> Get()
        {

            try
            {
                return  service.GetNominaRegistros();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

     
    }
}
