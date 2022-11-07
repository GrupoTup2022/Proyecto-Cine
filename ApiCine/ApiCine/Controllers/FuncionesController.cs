using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionesController : ControllerBase
    {
        public IFuncionService fs;

        public FuncionesController()
        {
            fs = new FuncionService();
        }

        [HttpGet]
        [Route("Peliculas")]
        public IActionResult GetPeliculas()
        {
            return Ok(fs.consultarPeliculas());
        }

        [HttpGet]
        [Route("Funciones")]
        public IActionResult GetFunciones()
        {
            return Ok(fs.consultarFunciones());
        }

        [HttpGet]
        [Route("Horarios")]
        public IActionResult GetHorarios()
        {
            return Ok(fs.consutlarHorarios());
        }
        [HttpGet]
        [Route("Audios")]
        public IActionResult GetAudios()
        {
            return Ok(fs.consultarAudios());
        }
        [HttpGet]
        [Route("Salas")]
        public IActionResult GetSalas()
        {
            return Ok(fs.consultarSalas());
        }
    }
}
