using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examenes.WebApi.Data.Entities
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        
    }
}
