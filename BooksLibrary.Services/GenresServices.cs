using BooksLibrary.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksLibrary.Models;
using BooksLibrary.Data.Repositories;
using BooksLibrary.Data.UnitsOfWork;

namespace BooksLibrary.Services
{
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
