﻿using Faculty.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Data
{
    public class ResourceDbContext:DbContext
    {
        public ResourceDbContext(DbContextOptions<ResourceDbContext> options):base(options)
        {

        }

        public DbSet<Resource> Resources { set; get; }
    }
}
