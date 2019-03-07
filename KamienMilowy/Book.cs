using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowy
{
    class Book
    {
        public string Title;
        public string Author;
        public string Type;
        public string Description;
        public int Pages;
        public double Price;
        public int EditionDate;
        public string Editor;
        public bool Availabilty;

        public Book(string title, string author, string type, string description, int pages, double price, int editionDate, string editor, bool availabilty)
        {
            Title = title;
            Author = author;
            Type = type;
            Description = description;
            Pages = pages;
            Price = price;
            EditionDate = editionDate;
            Editor = editor;
            Availabilty = availabilty;
        }

        public void ShowDetailsOfBook()
        {
            Console.WriteLine("Tytuł: " + Title);
            Console.WriteLine("Autor: " + Author);
            Console.WriteLine("Typ: " + Type);
            Console.WriteLine("Opis: " + Description);
            Console.WriteLine("Ilość stron: " + Pages);
            Console.WriteLine("Cena: " + Price);
            Console.WriteLine("Data wydania: " + EditionDate);
            Console.WriteLine("Edytor: " + Editor);
            Console.WriteLine("Dostępność: " + Availabilty);
            Console.WriteLine("");
        }

    }
}
