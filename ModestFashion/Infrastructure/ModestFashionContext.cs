using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModestFashion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModestFashion.Infrastructure
{
    public class ModestFashionContext : IdentityDbContext<AppUser>
    {
        public ModestFashionContext(DbContextOptions<ModestFashionContext> options)
            :base(options)
        {

        }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
