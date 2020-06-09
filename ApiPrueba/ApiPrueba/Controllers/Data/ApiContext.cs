using ApiPrueba.Controllers.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Controllers.Data
{
    public class ApiContext : DbContext 
    {
        public ApiContext(DbContextOptions<ApiContext>options) : base(options)
        {
                
        }

        public DbSet<Producto> Productos{ get; set; }
    }
}
