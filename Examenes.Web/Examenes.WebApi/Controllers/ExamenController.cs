using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examenes.WebApi.Data;
using Examenes.WebApi.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examenes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamenController : ControllerBase
    {
        private readonly ApiContext context;

        public ExamenController(ApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Examen>> Get()
        {
            return context.Examenes.Include(p => p.Alumno).ToList();
        }

        
        [HttpGet("ExamenById/{id}", Name = "ExamenById")]
        public ActionResult<Examen> GetExamenById(int id)
        {
            var examen = context.Examenes.FirstOrDefault(p => p.Id == id);
            if (examen == null)
            {
                return NotFound();
            }
            return examen;
        }

        [HttpGet("ListaExamen")]
        public List<Examen> GetListaExamen()
        {
           return context.Examenes.Include(p=>p.Alumno).ToList();
            
        }
     /*   [HttpGet("ExamenbyApellido/{Apellido}")]
        public ActionResult<Examen> GetExamenbyApellido(string alum)
        {
            var examen = context
                            .Examenes
                            .Include(p => p.Alumno).FirstOrDefault(p => p.Alumno.Apellido == alum);
            if (examen == null)
            {
                return NotFound();
            }
            return examen;
        }*/

        [HttpPost]
         public ActionResult<Examen> Post([FromBody] Examen examen)
         {
             context.Examenes.Add(examen);
             context.SaveChanges();

             return new CreatedAtRouteResult("exambyId", new { id = examen.Id }, examen);
         }

        [HttpPost("Corregir")]
        public ActionResult<Examen> EditarNota(ReqExamen entrada)
        {
            
            Examen examen = context.Examenes.FirstOrDefault(x => x.Id == entrada.id_examen);
            if (examen == null)
            {
                return BadRequest();
            }
            else
            {
                examen.Nota = entrada.nota;
                examen.Comentario = entrada.comentario;
            }
            context.Examenes.Update(examen);
            
            context.SaveChanges();

            return new CreatedAtRouteResult("exambyId", new { id = examen.Id }, examen);
        }

        [HttpDelete("{id}")]
        public ActionResult<Examen> Delete(int id)
        {
            var examen = context.Examenes.FirstOrDefault(p => p.Id == id);
            if (examen == null)
            {
                return NotFound();
            }
            context.Examenes.Remove(examen);
            context.SaveChanges();
            return Ok();
        }
    }
}
