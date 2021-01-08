using Microsoft.EntityFrameworkCore;
using ProjetoDashboards.Domain.Entities;
using ProjetoDashboards.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDashboards.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<MovimentacaoFinanceira> MovimentacaoFinanceira { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovimentacaoFinanceiraMap());
        }
    }
}
