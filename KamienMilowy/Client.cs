using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowy
{
    class Client
    {
        private string _name;
        private string _surname;
        private string _city;
        private string _street;
        private int _flatNumber;
        private int _numberOfBooks;

        public Client(string name, string surname, string city, string street, int flatNumber, int numberOfBooks)
        {
            _name = name;
            _surname = surname;
            _city = city;
            _street = street;
            _flatNumber = flatNumber;
            _numberOfBooks = numberOfBooks;
        }

        public void ShowClients()
        {
            Console.WriteLine("Imię: " + _name + " Nazwisko: " + _surname + " Adres: " + _street + " " + _flatNumber + " Ilość przeczytanych książek: " + _numberOfBooks);
        }


    }
}
