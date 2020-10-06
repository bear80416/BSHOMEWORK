﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPITOO.Models;

namespace WEBAPITOO.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext>options):base(options)
        {

        }
        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
