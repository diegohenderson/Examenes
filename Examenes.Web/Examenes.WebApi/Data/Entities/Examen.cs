using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examenes.WebApi.Data.Entities
{
    public class Examen
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }// hoy llovio?
        public string Respuesta { get; set; }//si o por no
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public Alumno  Alumno { get; set; }
    }
}
