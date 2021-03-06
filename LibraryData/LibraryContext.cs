﻿using LibraryData.Modles;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }
        public DbSet<Patron> Patron { get; set; }
    }
}
