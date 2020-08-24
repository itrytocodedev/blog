using itrytocode.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itrytocode.Data
{
    public class ItrytocodeContext : DbContext
    {
        public ItrytocodeContext(DbContextOptions<ItrytocodeContext> options)
            : base(options)
        {
        }

        public DbSet<PostModel> Posts { get; set; }
    }
}
