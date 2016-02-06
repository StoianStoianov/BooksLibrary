using BooksLibrary.Data;
using BooksLibrary.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksLibrary.Web.App_Start
{
    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BooksLibraryDbContext, Configuration>());
            BooksLibraryDbContext.Create().Database.Initialize(true);
        }
    }
}