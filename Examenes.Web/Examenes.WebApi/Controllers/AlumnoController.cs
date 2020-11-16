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
    public class AlumnoController : ControllerBase
    {
        private readonly ApiContext context;

        public AlumnoController(ApiContext context)
        {
            this.context = context;
        }

        //Get de La lista Entera.
        [HttpGet]
        public ActionResult<List<Alumno>> Get()
        {
            return context.Alumnos.ToList();
        }

        //por id.
        [HttpGet("{id}", Name = "ObtenerAlumnoPorID")]
        public ActionResult<Alumno> Get(int id)
        {
            var alumno = context.Alumnos.FirstOrDefault(p => p.Id == id);
            if (alumno == null)
            {
                return NotFound();

            }
            return alumno;
        }

        [HttpPost]
        public async Task<ActionResult<Alumno>> Post([FromBody] Alumno alumno)
        {

            await context.Alumnos.AddAsync(alumno);

            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("obtenerAlumnoPorId", new { id = alumno.Id }, alumno);


        }

        [HttpPut("{id}")]
        public ActionResult<Alumno> Put(int id, [FromBody] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return BadRequest();
            }
            context.Entry(alumno).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult<Alumno> Delete(int id)
        {
            var alumno = context.Alumnos.FirstOrDefault(p => p.Id == id);
            if (alumno == null)
            {
                return NotFound();
            }
            context.Alumnos.Remove(alumno);
            context.SaveChanges();
            return Ok();
        }

    }
}