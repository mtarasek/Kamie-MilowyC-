using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] tab = new Book[3];
            tab[0] = new Book("Pan Tadeusz", "Adam Mickiewicz", "Epos", "Pan Tadeusz, czyli Ostatni zajazd na Litwie", 296, 20.35, 1834, "Samuel Merzbach", true);
            tab[1] = new Book("rrrrr", "tttt rrrr", "Epoeeees", "Pan Tadeusz, czyli Ostatni zajazd na Litwie", 296, 20.35, 1834, "Samuel Merzbach", true);
            tab[2] = new Book("rrrrr", "tttt rrrr", "Epoeeees", "Pan Tadeusz, czyli Ostatni zajazd na Litwie", 296, 20.35, 1834, "Samuel Merzbach", true);

            tab[0].ShowDetailsOfBook();
            tab[1].ShowDetailsOfBook();
            tab[2].ShowDetailsOfBook();

            //foreach (Book x in tab)
            //{
            //    x.ShowDetailsOfBook();
            //}
            SearchBooks search = new SearchBooks();

            Console.WriteLine("Podaj tytuł szukanej ksiązki: ");
            string provided = Console.ReadLine();
            search.SearchTitle(tab, provided);
            

            Employee[] employeesTab = new Employee[10];
            employeesTab[0] = new Employee("Monika", "Nowak", Sex.Kobieta, "Gdańsk", "Kunegundy", 34, 2000, "Bob", 2017, "Programistka");
            employeesTab[1] = new Employee("Adam", "Nowak", Sex.Mężczyzna, "Gdańsk", "Kunegundy", 34, 3020, "Bob", 2017, "Programistka");
            employeesTab[0].AddToSalary(20);
            employeesTab[1].CutSalary(200);
            employeesTab[0].ChangePosition("hydraulik");



            Client client1 = new Client("Jan", "Kowalski", "Poznań", "Gertrudy", 22, 10);
            client1.ShowClients();


            Console.ReadKey();
        }
    }
}
