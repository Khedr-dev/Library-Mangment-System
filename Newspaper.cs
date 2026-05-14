using System;

namespace LibraryApp
{
    public class Newspaper : LibraryItem
    {
        public string Publisher { get; set; }

        public Newspaper(string title, int year, string publisher)
            : base(title, year)
        {
            Publisher = publisher;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Newspaper: {Title} - {Publisher} ({Year})");
        }
        public override bool Validate()
        {
            return ValidationHelper.IsValidTitle(Title)
                && ValidationHelper.IsValidYear(Year)
                && ValidationHelper.IsValidPublisher(Publisher);
        }
    }
}