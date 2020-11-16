using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Examenes.Web.Data.Entities
{
    public class Examen
    {
        public int Id { get; set; }

        public string NombreAlumno { get; set; }
        [DisplayName("Nombre Alumno")]
        public string ApellidoAlumno { get; set; }
        [DisplayName("Apellido Alumno")]
        public string Materia { get; set; }
        public string DescripcionExamen { get; set; }
        [DisplayName("Comentarios")]
        public int Nota { get; set; }
        
    }
}
