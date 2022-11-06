
using DataCine.Servicios.Implementacion;
using DataCine.Servicios.Interfaces;
using LibreriaTp;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesController : ControllerBase
    {

        public IComprobanteService cs;

        public ComprobantesController()
        {
            cs = new ComprobanteService();
        }

        // Put api/<ComprobanteController>
        [HttpPut]
        public bool InsertComprobante([FromBody]Comprobante comprobante)
        {
            return cs.CargarComprobante(comprobante);
        }

        // Get api/<ComprobanteController>/Funciones/2022-10-23
        [HttpPost]
        [Route("Funciones")]
        public List<Funcion> ConsultarFunciones([FromBody] string Fecha)
        {
            DateTime fecha = Convert.ToDateTime(Fecha);
            return cs.ConsultarFunciones(fecha);
        }

        // Get api/<ComprobanteController>/Butacas/1
        [HttpPost]
        [Route("Butacas")]
        public List<TipoGenerico> ConsultarButacas([FromBody] int ID)
        {
            return cs.ConsultarButacas(ID);
        }

    }
}
