namespace BooksLibrary.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<BooksLibrary.Data.BooksLibraryDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BooksLibrary.Data.BooksLibraryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            if (context.Genres.Any())
            {
                return;
            }

            context.Genres.Add(new Models.Genre { GenreName = "Horror" });
            context.Genres.Add(new Models.Genre { GenreName = "Comedy" });
            context.Genres.Add(new Models.Genre { GenreName = "Biography" });

            context.SaveChanges();

            var ComedyGenre = context.Genres.Where(genre => genre.GenreName == "Comedy").FirstOrDefault();
            var HorrorGenre = context.Genres.Where(genre => genre.GenreName == "Horror").FirstOrDefault();
            var BiographtGenre = context.Genres.Where(genre => genre.GenreName == "Biography").FirstOrDefault();

            context.Books.Add(new Models.Book { Title = "Harry Potter 1", PageCount = 200, CreationDate = DateTime.Now, Genre = HorrorGenre, Url = "/Images/child-little-boy-glasses-reading-book-over-school-black-board-chalk-drawing-kids-preschool-development-children-education-53439061.jpg" });           
            context.Books.Add(new Models.Book { Title = "Harry Potter 2", PageCount = 300, CreationDate = DateTime.Now, Genre = HorrorGenre, Url = "/Images/child-reading-book-little-girl-exciting-35660572.jpg" });
            context.Books.Add(new Models.Book { Title = "Harry Potter 3", PageCount = 400, CreationDate = DateTime.Now, Genre = HorrorGenre, Url = "/Images/child-reading-old-book-brown-bookcover-armchair-home-62957928.jpg" });
            context.Books.Add(new Models.Book { Title = "Harry Potter 4", PageCount = 500, CreationDate = DateTime.Now, Genre = HorrorGenre, Url = "/Images/funny-baby-girl-glasses-reading-book-library-38073035.jpg" });
            context.Books.Add(new Models.Book { Title = "Harry Potter 5", PageCount = 600, CreationDate = DateTime.Now, Genre = HorrorGenre, Url = "/Images/girl-reading-book-stack-books-37148287.jpg" });
            context.Books.Add(new Models.Book { Title = "Harry Potter 6", PageCount = 250, CreationDate = DateTime.Now, Genre = HorrorGenre, Url = "/Images/magic-book-open-38185037.jpg" });
            context.Books.Add(new Models.Book { Title = "Don Kihot", PageCount = 111, CreationDate = DateTime.Now, Genre = ComedyGenre, Url = "/Images/open-old-book-isolated-white-background-46691535.jpg" });
            context.Books.Add(new Models.Book { Title = "Pippi Longstocking", PageCount = 45, CreationDate = DateTime.Now, Genre = ComedyGenre, Url = "/Images/reading-book-girl-absorbed-46742425.jpg" });
            context.Books.Add(new Models.Book { Title = "Mike Tyson Biography", PageCount = 500, CreationDate = DateTime.Now, Genre = BiographtGenre, Url = "/Images/school-girl-reading-book-white-young-glasses-icons-such-as-math-formulas-animals-nature-objects-around-her-40435797.jpg" });
            context.Books.Add(new Models.Book { Title = "Ronaldo Biography", PageCount = 400, CreationDate = DateTime.Now, Genre = BiographtGenre, Url = "/Images/woman-reading-book-sitting-sofa-home-looking-down-33413003.jpg" });
            context.Books.Add(new Models.Book { Title = "Hitler Biography", PageCount = 500, CreationDate = DateTime.Now, Genre = BiographtGenre, Url = "/Images/school-girl-reading-book-white-young-glasses-icons-such-as-math-formulas-animals-nature-objects-around-her-40435797.jpg" });
            context.Books.Add(new Models.Book { Title = "GSP Biography", PageCount = 400, CreationDate = DateTime.Now, Genre = BiographtGenre, Url = "/Images/woman-reading-book-sitting-sofa-home-looking-down-33413003.jpg" });



        }
    }
}
