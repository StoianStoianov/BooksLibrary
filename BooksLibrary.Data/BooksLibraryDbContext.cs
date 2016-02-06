﻿using BooksLibrary.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BooksLibrary.Data
{
    public class BooksLibraryDbContext : IdentityDbContext<User>,IBooksLibraryDbContext
    {
        public BooksLibraryDbContext()
            : base("BooksLibrary")
        {
        }
        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Genre> Genres { get; set; }
        public static BooksLibraryDbContext Create()
        {
            return new BooksLibraryDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity:class
        {
            return base.Set<TEntity>();
        }
    }
}