using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mandiras_Store.Entities;
using Microsoft.EntityFrameworkCore;

namespace Mandiras_Store.Data
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Product> Products {get; set;}
    }
}