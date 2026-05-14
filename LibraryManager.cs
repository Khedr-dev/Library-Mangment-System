using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class LibraryManager
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public static int TotalItems { get; private set; } = 0;

        public delegate void ItemAddedHandler(LibraryItem item);
        public event ItemAddedHandler ItemAdded;

        public void AddItem(LibraryItem item)
        {
            if (item.Validate())
            {
                items.Add(item);
                TotalItems++;
                ItemAdded?.Invoke(item);
            }
        }

        public void ShowAll()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
}