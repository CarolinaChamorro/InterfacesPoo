﻿using Microsoft.EntityFrameworkCore;
using Profesiones.Entidad;
using System;

namespace Profesiones.AccesoDatos
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Carpintero> Carpinteros { get; set; }

    }
}
