using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowy
{
    class SearchBooks
    {
        public void SearchTitle(Book[] tab, string provided)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Book book = tab[i];
                if (book.Title == provided)
                {
                    Console.WriteLine("Szukana książka jest w systemie: ");
                    book.ShowDetailsOfBook();
                }
                if (book.Title != provided)
                {
                    Console.Write("Ksiązka nie znajduje się w systemie");
                }
            }
        }
    }
}
