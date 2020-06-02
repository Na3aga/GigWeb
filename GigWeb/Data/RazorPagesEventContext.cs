using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GigWeb.Models;

    public class RazorPagesEventContext : DbContext
    {
        public RazorPagesEventContext (DbContextOptions<RazorPagesEventContext> options)
            : base(options)
        {
        }

        public DbSet<GigWeb.Models.Invitation> Invitation { get; set; }

        public DbSet<GigWeb.Models.Event> Event { get; set; }
    }
