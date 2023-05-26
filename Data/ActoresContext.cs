using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial_Web.Models;

namespace Parcial_Web.Data
{
    public class ActoresContext : DbContext
    {
        public ActoresContext (DbContextOptions<ActoresContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial_Web.Models.Actor> Actor { get; set; } = default!;

        public DbSet<Parcial_Web.Models.Pelicula> Pelicula { get; set; } = default!;
    }
}
