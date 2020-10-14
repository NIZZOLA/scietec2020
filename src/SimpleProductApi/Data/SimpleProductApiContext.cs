using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleProductApi.Models;

namespace SimpleProductApi.Data
{
    public class SimpleProductApiContext : DbContext
    {
        public SimpleProductApiContext (DbContextOptions<SimpleProductApiContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleProductApi.Models.ProdutoModel> ProdutoModel { get; set; }
    }
}
