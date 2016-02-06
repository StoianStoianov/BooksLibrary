using BooksLibrary.Models;
using BooksLibrary.Services.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Validation;

namespace BooksLibrary.Web
{
    public partial class _Default : Page
    {
        [Inject]
        public IBooksServices BooksServices { get; set; }
        [Inject]
        public IGenresServices GenreServices { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string imgName = FileUpload.FileName;
            string imgPath = "App_Data/" + imgName;

            try
            {
                this.SavePicture(imgPath);
                this.InsertBook(imgPath);
            }
            catch (Exception ex)
            {
                this.ErrorTextBox.Visible = true;
                this.ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                this.ErrorTextBox.Text = ex.Message;
            }


            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SavePicture(string imgPath)
        {           
            int imgSize = FileUpload.PostedFile.ContentLength;

            if (FileUpload.PostedFile != null && FileUpload.PostedFile.FileName != string.Empty)
            {
                if(imgSize > 300000)
                {
                    throw new ArgumentException("The image size is too big!");
                }

                FileUpload.SaveAs(Server.MapPath(imgPath));
            }
            else
            {
                throw new ArgumentException("Image path must not be null or empty!");
            }
        }

        private void InsertBook(string imgPath)
        {
            Validator validator = new Validator();
            
            string title = this.TitleTextBox.Text;
            validator.ValidateTitleLength(title,3);

            int pagesCount = int.Parse(this.PageCountTextBox.Text);
            validator.ValidatePageCount(pagesCount, 0, 5000);

            string genreName = this.GenreDownList.SelectedValue;
            Genre genre = this.GenreServices.GetGenre(genreName);

            var book = new Book()
            {
                Title = title,
                PageCount = pagesCount,
                Genre = genre,
                CreationDate = DateTime.Now,
                Url = imgPath
            };

            this.BooksServices.AddBook(book);
            this.ErrorTextBox.Visible = false;
        }
    }
}