using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.api.model;
using Microsoft.EntityFrameworkCore;

namespace ProEventos.api.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        public DbSet<Evento> Eventos { get; set;}
    }
}