namespace LibraryProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book
    {
        public Book(string title, string barcode, string genre, string author, string fiction, string image, bool safeguarding, string info, string isbn, string publicationdate)
        {
            this.Title = title;
            this.Barcode = barcode;
            this.Genre = genre;
            this.Author = author;
            this.Fiction = fiction;
            this.Image = image;
            this.Safeguarding = safeguarding;
            this.Info = info;
            this.Isbn = isbn;
            this.PublicationDate = publicationdate;
        }

        private Book()
        {
        }

        public string Title { get; set; }

        [Key]
        public string Barcode { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        public string Fiction { get; set; }

        // public List<Author> Authors { get; set; } = new List<Author>();
        public List<ReturnsLog> ReturnsLogs { get; set; }

        public string Image { get; set; }

        public bool Safeguarding { get; set; }

        public string Info { get; set; }

        public string PublicationDate { get; set; }

        public string Isbn { get; set; }
    }
}
