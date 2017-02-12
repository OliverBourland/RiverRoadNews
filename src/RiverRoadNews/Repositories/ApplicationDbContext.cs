﻿using Microsoft.EntityFrameworkCore;
using RiverRoadNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<NewsEvents> NewsEvents { get; set; }
    }
}
