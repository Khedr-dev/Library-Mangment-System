using System;

namespace LibraryApp
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int year, int issueNumber)
            : base(title, year)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Title} - Issue {IssueNumber} ({Year})");
        }
        public override bool Validate()
        {
            return ValidationHelper.IsValidTitle(Title)
                && ValidationHelper.IsValidYear(Year)
                && ValidationHelper.IsValidIssue(IssueNumber);
        }
    }
}