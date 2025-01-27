﻿using LibraryApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.API.Data
{
    /// <summary>
    /// klasa zawierajaca polaczenie do bazy danych jak również wszystkie klasy ktore maja byc odwzorowane w bazie danych
    /// zostało zastosowane podejscie Code-First, uzywajac migracji
    /// </summary>
    public class LibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<CopiesOfTheBook> CopiesOfTheBooks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Borrowed> Borroweds { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
