using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.Controllers
{
    public class PersonaController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Add(Models.Request.PersonaRequest model)
        {
            using(Models.pruebillafelizEntities2 db = new Models.pruebillafelizEntities2())
            {
                var oPersona = new Models.personas();
                oPersona.nombre = model.Nombre;
                oPersona.edad = model.Edad;
                db.personas.Add(oPersona);
                db.SaveChanges();

            }

            return Ok("Exito");


        }
    }
}
