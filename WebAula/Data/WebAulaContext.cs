﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAula.Models;

namespace WebAula.Data
{
    public class WebAulaContext : DbContext
    {
        public WebAulaContext (DbContextOptions<WebAulaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAula.Models.Department> Department { get; set; }
    }
}
