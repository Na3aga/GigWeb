using System;
using System.Collections.Generic;
using System.Text;
using GigWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GigWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<GigUser, GigRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
    
    
}