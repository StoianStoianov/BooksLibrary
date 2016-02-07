namespace BooksLibrary.Web
{
    using BooksLibrary.Models;
    using BooksLibrary.Services.Contracts;
    using Ninject;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.ModelBinding;
    public partial class BookList : System.Web.UI.Page
    {
        [Inject]
        public IBooksServices BooksServices { get; set; }
        [Inject]
        public IGenresServices GenreServices { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Book> BooksLibrary_GetData()
        {
            string searchBy = this.SearchOptions.SelectedItem.Text;
            string searchText = this.SearchTextBox.Text;

            switch (searchBy)
            {
                case "Name": return BooksServices.SearchByTitle(searchText); 
                case "Page count": return BooksServices.SearchByPage(int.Parse(searchText)); 
                case "Genre": return BooksServices.SearchByGenre(searchText);
            }

            return this.BooksServices.GetAll();
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            this.BooksLibrary_GetData();
        }

        private void SearchByTitle()
        {

        }
    }
}