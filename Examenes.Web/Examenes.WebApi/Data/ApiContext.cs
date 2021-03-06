﻿using Examenes.WebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examenes.WebApi.Data
{
    public class ApiContext: DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
