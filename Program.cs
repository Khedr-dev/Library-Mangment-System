using System;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LibraryManager manager = new LibraryManager();

            manager.ItemAdded += (item) =>
            {
                Console.WriteLine("تمت إضافة عنصر جديد: " + item.Title);
            };

            manager.AddItem(new Book("Clean Code", 2008, "Robert Martin"));
            manager.AddItem(new Magazine("Tech Monthly", 2023, 42));
            manager.AddItem(new Newspaper("Daily News", 2024, "NY Times"));

            Console.WriteLine("\n--- عناصر المكتبة ---");
            manager.ShowAll();

            Console.WriteLine("\nعدد العناصر الكلي: " + LibraryManager.TotalItems);

            Console.ReadLine();
        }
    }
}