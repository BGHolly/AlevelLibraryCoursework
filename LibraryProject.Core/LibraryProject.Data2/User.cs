namespace LibraryProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Cryptography.KeyDerivation;

    public class User
    {
        public User(string firstname, string lastname, string email, string password, string year, char gender)
        {
            this.Status = "Unknown";
            int constant;
            if (DateTime.Now.Month > 8)
            {
                constant = 14;
            }
            else
            {
                constant = 13;
            }

            if (year == "Year 9" | year == "Year 10" | year == "Year 11")
            {
                this.Status = "Student";
                this.Year = DateTime.Now.Year + constant - short.Parse(year.Remove(0, 5));
            }
            else if (year == "Year 12" | year == "Year 13")
            {
                this.Status = "Sixth-Form";
                this.Year = DateTime.Now.Year + constant - short.Parse(year.Remove(0, 5));
            }
            else if (year == "Staff")
            {
                this.Status = "Staff";
            }

            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Gender = gender;
            this.Password = LibraryDataFunctions.Makehash(password, email);
        }

        private User()
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Key]
        public string Email { get; set; }

        public string Password { get; set; }

        public string Status { get; set; }

        public char Gender { get; set; }

        public int Year { get; set; }

        public List<ReturnsLog> ReturnsLogs { get; set; }
    }
}
