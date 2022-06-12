using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simbora04.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Sugestao> Sugestoes { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
    }
}
