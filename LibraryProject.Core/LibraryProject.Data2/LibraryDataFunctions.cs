namespace LibraryProject.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Microsoft.AspNetCore.Cryptography.KeyDerivation;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Internal;

    public class LibraryDataFunctions
    {
        public static void AddUser(string firstname, string lastname, string email, string password, string status, string year, char gender)
        {
            using (var context = new LibraryDbContext())
            {
                var user = new User(firstname, lastname, email, password, year, gender);

                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static void EditUser(string firstname, string lastname, string email, string status, string password, char gender)
        {
            using (var context = new LibraryDbContext())
            {
                var user = (from d in context.Users where d.Email == email select d).FirstOrDefault();
                user.Password = password;
                user.FirstName = firstname;
                user.LastName = lastname;
                user.Gender = gender;
                user.Status = status;
                context.SaveChanges();
            }
        }

        public static bool UserExists(string email)
        {
            using (var context = new LibraryDbContext())
            {
                if (context.Users.Any(d => d.Email == email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static string LoginValid(string email, string password)
        {
                string hash = Makehash(password, email);
                using (var context = new LibraryDbContext())
                {
                    if (context.Users.Any(d => d.Email == email))
                    {
                        var user = (from d in context.Users where d.Email == email & d.Password == hash select d).FirstOrDefault();
                        if (user == null)
                        {
                            return "false";
                        }
                        else
                        {
                            return user.Status;
                        }
                    }
                }

                return "false";
        }

        public static User GetUser(string email)
        {
            if (UserExists(email))
            {
                using (var context = new LibraryDbContext())
                {
                    var currentuser = (from d in context.Users where d.Email == email select d).FirstOrDefault();
                    return currentuser;
                }
            }
            else
            {
                return null;
            }
        }

        public static void RemoveUser(string email)
        {
            using (var context = new LibraryDbContext())
            {
                var user = (from d in context.Users where d.Email == email select d).FirstOrDefault();
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public static void AddBook(string title, string barcode, string genre, string author, string fiction, string image, bool safeguarding, string info, string isbn, string publicationdate)
        {
            using (var context = new LibraryDbContext())
            {
                if (BookExists(barcode) == false)
                {
                    var book = new Book(title, barcode, genre, author, fiction, image, safeguarding, info, isbn, publicationdate);
                    context.Books.Add(book);
                    context.SaveChanges();
                }
            }
        }

        public static void RemoveBook(string barcode)
        {
            using (var context = new LibraryDbContext())
            {
                var book = (from d in context.Books where d.Barcode == barcode select d).FirstOrDefault();
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }

        public static void EditBook(string title, string barcode, string genre, string author, string fiction, string image, bool safeguarding, string info, string isbn, string publicationdate)
        {
            if (GetBook(barcode) != null)
            {
                using (LibraryDbContext context = new LibraryDbContext())
                {
                    var book = (from d in context.Books where d.Barcode == barcode select d).FirstOrDefault();
                    book.Title = title;
                    book.Genre = genre;
                    book.Author = author;
                    book.Fiction = fiction;
                    book.Image = image;
                    book.Safeguarding = safeguarding;
                    book.Info = info;
                    book.Isbn = isbn;
                    book.PublicationDate = publicationdate;
                    context.SaveChanges();
                }
            }
        }

        public static Book GetBook(string barcode)
        {
            if (BookExists(barcode))
            {
                using (var context = new LibraryDbContext())
                {
                    var currentbook = (from d in context.Books where d.Barcode == barcode select d).FirstOrDefault();
                    return currentbook;
                }
            }
            else
            {
                return null;
            }
        }

        public static void AddLog(string barcode, string email)
        {
            using (var context = new LibraryDbContext())
            {
                var returned = (from d in context.Returns where d.BookBarcode == barcode select d).FirstOrDefault();
                if (returned != null)
                {
                    if (returned.Returned != true)
                    {
                        MessageBox.Show("Book has not been returned by the user who took it out, please ask for assistance");
                    }
                    else
                    {
                        var returnsLog = new ReturnsLog(DateTime.Now, barcode, email);
                        context.Returns.Add(returnsLog);
                        context.SaveChanges();
                    }
                }
                else
                {
                    var returnsLog = new ReturnsLog(DateTime.Now, barcode, email);
                    context.Returns.Add(returnsLog);
                    context.SaveChanges();
                }
            }
        }

        public static void CloseLog(string barcode, string email)
        {
            using (var context = new LibraryDbContext())
            {
                var user = (from d in context.Returns where d.BookBarcode == barcode select d).FirstOrDefault();
                if (user.UserEmail != email)
                {
                    MessageBox.Show("you did not take this book out, you cannot return books on another's behalf. please ask for assistance");
                }
                else
                {
                    var log = (from d in context.Returns where d.BookBarcode == barcode & d.UserEmail == email & d.Returned == false select d).FirstOrDefault();
                    log.Returned = true;
                    context.SaveChanges();
                }
            }
        }

        public static bool BookExists(string barcode)
        {
            using (var context = new LibraryDbContext())
            {
                if (context.Books.Any(o => o.Barcode == barcode))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static object GetReport(string type, string scope)
        {
            using (var context = new LibraryDbContext())
            {
                var report = (from d in context.Returns select d).ToList();
                if (type == "Current Loans")
                {
                    report = report.Where(d => d.Returned == false).ToList();
                }

                if (type == "Past Loans")
                {
                    report = report.Where(d => d.Returned == true).ToList();
                }

                if (type == "Overdue Loans")
                {
                    report = report.Where(d => d.Returned == false & d.DateDue > DateTime.Now).ToList();
                }

                if (scope == "Girls")
                {
                    report = report.Where(d => d.User.Gender == 'F').ToList();
                }

                if (scope == "Boys")
                {
                    report = report.Where(d => d.User.Gender == 'M').ToList();
                }

                if (scope == "Fiction")
                {
                    report = report.Where(d => d.Book.Fiction == "Fiction").ToList();
                }

                if (scope == "Non-Fiction")
                {
                    report = report.Where(d => d.Book.Fiction == "Non-Fiction").ToList();
                }

                int currentyear = DateTime.Now.Year;
                if (DateTime.Now.Month < 8)
                {
                    currentyear -= 1;
                }

                if (scope == "Year 9")
                {
                    report = report.Where(d => d.User.Year == DateTime.Now.Year + 5).ToList();
                }

                if (scope == "Year 10")
                {
                    report = report.Where(d => d.User.Year == DateTime.Now.Year + 4).ToList();
                }

                if (scope == "Year 11")
                {
                    report = report.Where(d => d.User.Year == DateTime.Now.Year + 3).ToList();
                }

                if (scope == "Year 12")
                {
                    report = report.Where(d => d.User.Year == DateTime.Now.Year + 2).ToList();
                }

                if (scope == "Year 13")
                {
                    report = report.Where(d => d.User.Year == DateTime.Now.Year + 1).ToList();
                }

                if (scope == "Dewey Decimal Type:*")
                {
                    report = report.Where(d => d.Book.Genre == scope.Substring(19)).ToList();
                }

                return report;
            }
        }

        public static List<User> GetYearGroup(string yeargroup)
        {
            using (var context = new LibraryDbContext())
            {
                int constant;
                if (DateTime.Now.Month > 8)
                {
                    constant = 14;
                }
                else
                {
                    constant = 13;
                }

                var users = (from d in context.Users select d).ToList();
                if (yeargroup == "Year 9s")
                {
                    users = users.Where(d => d.Year == DateTime.Now.Year + constant - 9).ToList();
                }
                else if (yeargroup == "Year 10s")
                {
                    users = users.Where(d => d.Year == DateTime.Now.Year + constant - 10).ToList();
                }
                else if (yeargroup == "Year 11s")
                {
                    users = users.Where(d => d.Year == DateTime.Now.Year + constant - 11).ToList();
                }
                else if (yeargroup == "Year 12s")
                {
                    users = users.Where(d => d.Year == DateTime.Now.Year + constant - 12).ToList();
                }
                else if (yeargroup == "Year 13s")
                {
                    users = users.Where(d => d.Year == DateTime.Now.Year + constant - 13).ToList();
                }
                else if (yeargroup == "ex-students")
                {
                    users = users.Where(d => d.Year < DateTime.Now.Year + constant - 13).ToList();
                }
                else if (yeargroup == "staff")
                {
                    users = users.Where(d => d.Year == 0).ToList();
                }

                return users;
            }
        }

        public static string Makehash(string password, string email)
        {
            byte[] salt = Encoding.ASCII.GetBytes(email);
            var bytes = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA512, 10000, 16);
            string passhash = Encoding.ASCII.GetString(bytes);
            return passhash;
        }

        public static string[,] GetReccomendations()
        {
            string[,] reccomendations = new string[10, 4];
            using (var context = new LibraryDbContext())
            {
                var recents = (from d in context.Returns orderby d.DateOut descending where d.Returned == true select d.Book).ToList();
                int max = 10;
                if (recents.Count < 10)
                {
                    max = recents.Count;
                }

                for (int i = 0; i < max; i++)
                {
                    var item = recents.ElementAt(i);
                    var bookisout = (from d in context.Returns where d.Returned == true & d.Book.Title == item.Title select d.Book).FirstOrDefault();
                    if (bookisout != null)
                    {
                        reccomendations[i, 0] = item.Title;
                        reccomendations[i, 2] = item.Author;
                        reccomendations[i, 1] = item.Image;
                        reccomendations[1, 3] = item.Info;
                    }
                }
            }

            return reccomendations;
        }

        public static (List<string>, List<string>, List<string>, List<string>, List<string>) GetEmailBookDue()
        {
            using (var context = new LibraryDbContext())
            {
                List<string> days = null;
                List<string> name = (from d in context.Returns where d.DateDue <= DateTime.Now.AddDays(2) select d.User.FirstName).ToList<string>();
                List<string> email = (from d in context.Returns where d.DateDue <= DateTime.Now.AddDays(2) select d.UserEmail).ToList<string>();
                List<string> title = (from d in context.Returns where d.DateDue <= DateTime.Now.AddDays(2) select d.Book.Title).ToList<string>();
                List<string> author = (from d in context.Returns where d.DateDue <= DateTime.Now.AddDays(2) select d.Book.Author).ToList<string>();
                List<DateTime> datedue = (from d in context.Returns where d.DateDue <= DateTime.Now.AddDays(2) select d.DateDue).ToList<DateTime>();
                foreach (DateTime item in datedue)
                {
                    days.Add((item - DateTime.Now.AddDays(2)).Days.ToString());
                }

                return (name, email, title, author, days);
            }
        }

        public static List<string> GetSafeguardingConcern()
        {
            using (LibraryDbContext context = new LibraryDbContext())
            {
                List<string> concern = new List<string>();
                var results = (from d in context.Returns orderby d.User where d.Book.Safeguarding == true & d.DateOut < DateTime.Now.AddMonths(-3) select d).ToArray();
                int count = 1;
                for (int i = 0; i < results.Length; i++)
                {
                    if (results[i + 1].User == results[i].User)
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 2)
                        {
                            string text = results[i].UserEmail + ": ";
                            for (int j = 0; j < i + 1; j++)
                            {
                                text += results[j].Book.Title + " (" + results[j].Book.Author + ") ";
                            }

                            concern.Add(text + "\n\r");
                            count = 1;
                        }
                    }
                }

                return concern;
            }
        }
    }
}