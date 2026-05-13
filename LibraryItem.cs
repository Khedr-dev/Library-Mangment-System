namespace LibraryApp
{
    public abstract class LibraryItem : IItem
    {
        public int Id { get; }
        public string Title { get; set; }
        public int Year { get; set; }

        private static int nextId = 1;

        public LibraryItem(string title, int year)
        {
            Id = nextId++;
            Title = title;
            Year = year;
        }

        public abstract void DisplayInfo();

        public virtual bool Validate()
        {
            return !string.IsNullOrWhiteSpace(Title) && Year > 0;
        }

    }
}