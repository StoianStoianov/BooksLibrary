namespace BooksLibrary.Services
{
    using BooksLibrary.Services.Contracts;
    using System.Linq;
    using BooksLibrary.Models;
    using BooksLibrary.Data.UnitsOfWork;
    public class GenresServices : IGenresServices
    {
        private IUnitOfWork genres;

        public GenresServices(IUnitOfWork genres)
        {
            this.genres = genres;
        }
       
        public Genre GetGenre(string genre)
        {
            var repo = genres.Get<Genre>();
            return repo.All().Where(gen => gen.GenreName == genre).FirstOrDefault();
        }             
    }
}
