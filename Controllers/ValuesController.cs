using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cursos_Sistemas.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values -> SELECT -> Consultar informacion
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values -> INSERT -> Agregar/ingresar informacion
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5 -> UPDATE -> Actualizar/Modificar informacion
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5 -> DELETE -> Borrar informacion
        public void Delete(int id)
        {
        }
    }
}
