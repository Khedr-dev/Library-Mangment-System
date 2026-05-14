using System;

public static class ValidationHelper
{
    public static bool IsValidTitle(string title)
    {
        return !string.IsNullOrWhiteSpace(title);
    }

    public static bool IsValidYear(int year)
    {
        return year > 0;
    }

    public static bool IsValidAuthor(string author)
    {
        return !string.IsNullOrWhiteSpace(author);
    }

    public static bool IsValidPublisher(string publisher)
    {
        return !string.IsNullOrWhiteSpace(publisher);
    }

    public static bool IsValidIssue(int issue)
    {
        return issue > 0;
    }
}