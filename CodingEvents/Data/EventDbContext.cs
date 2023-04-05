﻿using System;
using CodingEvents.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEvents.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<EventCategory> Category { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options)
            : base(options)
        {
        }
    }
}

