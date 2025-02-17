﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineHotel.Models;


namespace OnlineHotel.BLL
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext>Options):
            base(Options)
        {
                
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Hotel> Hotels  { get; set; }
    }
}
