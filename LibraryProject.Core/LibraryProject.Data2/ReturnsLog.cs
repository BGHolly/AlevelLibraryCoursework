namespace LibraryProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReturnsLog
    {
        public ReturnsLog(DateTime dateout, string barcode, string email)
        {
            this.BookBarcode = barcode;
            this.UserEmail = email;
            this.DateOut = dateout;
            User user = LibraryDataFunctions.GetUser(this.UserEmail);
            if (user.Status == "Student")
            {
                this.DateDue = this.DateOut.AddDays(21);
            }

            if (user.Status == "VIP" | user.Status == "Sixth Form" | user.Status == "Staff")
            {
                this.DateDue = this.DateOut.AddDays(28);
            }

            this.Returned = false;
        }

        private ReturnsLog()
        {
        }

        public int LogId { get; set; }

        public string BookBarcode { get; set; }

        public Book Book { get; set; }

        public string UserEmail { get; set; }

        public User User { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime DateDue { get; set; }

        public bool Returned { get; set; }

        public void CloseLog()
        {
            this.Returned = true;
        }
    }
}
