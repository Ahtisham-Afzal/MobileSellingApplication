using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MobileSellingApplication.Models;

namespace MobileSellingApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MobileSellingApplication.Models.Mobile> Mobile { get; set; }
        public DbSet<MobileSellingApplication.Models.Manufacturer> Manufacturer { get; set; }

    }
}
