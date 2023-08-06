using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HappyBirthdayApp.Models;

namespace HappyBirthdayApp.Data
{
    public class HappyBirthdayAppContext : DbContext
    {
        public HappyBirthdayAppContext (DbContextOptions<HappyBirthdayAppContext> options)
            : base(options)
        {
        }

        public DbSet<HappyBirthdayApp.Models.Birthday> Birthday { get; set; } = default!;
    }
}
