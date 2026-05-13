using System;

namespace LibraryApp
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, int year, string author)
            : base(title, year)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title} - {Author} ({Year})");
        }
        public override bool Validate()
        {
            return ValidationHelper.IsValidTitle(Title)
                && ValidationHelper.IsValidYear(Year)
                && ValidationHelper.IsValidAuthor(Author);
        }
    }
}