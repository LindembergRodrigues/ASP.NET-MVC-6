﻿//using Microsoft.EntityFrameworkCore;
using CasaDoCodigoMVC.Models;
using System.Data.Entity;

namespace CasaDoCodigoMVC.Data
{
    public class EFContext : DbContext
    {
        public EFContext() //(DbContextOptions<EFContext> options)
            : base("BDCasaDoCodigoPDF")
        {
        }

        public DbSet<Categoria>? categoria { get; set; }
        public DbSet<Fabricante>? Fabricante { get; set; }
    }
}
