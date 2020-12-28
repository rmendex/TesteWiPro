using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WiProApiFila.Dominio.Entidades;

namespace WiProApiFila.Repositorio.Contexto
{
    public class WiProApiFilaContexto : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public WiProApiFilaContexto(DbContextOptions options) : base(options)
        {

        }
    }
}
