using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowy
{
    class Employee
    {
        private string _name;
        private string _surname;
        Sex Sex;
        private string _city;
        private string _street;
        private int _flatNumber;
        private int _salary;
        private string _manager;
        private int _dateOfEmployment;
        private string _position;

        public string Position { get; set; }


        public Employee(string name, string surname, Sex sex, string city, string street, int flatNumber, int salary, string manager, int dateOfEmloyment, string position)
        {
            _name = name;
            _surname = surname;
            _city = city;
            _street = street;
            _flatNumber = flatNumber;
            _salary = salary;
            _manager = manager;
            _dateOfEmployment = dateOfEmloyment;
            _position = position;
            Sex = Sex;
        }


        public void AddToSalary(int money)
        {
            _salary = _salary + money;
            Console.WriteLine("Wynagrodzenie po podwyżce wynosi: " + _salary);
        }

        public void CutSalary(int money)
        {
            _salary = _salary - money;
            Console.WriteLine("Wynagrodzenie po obniżce wynosi: " + _salary);
        }

        public void ShowEmployee()
        {
            Console.WriteLine("Imię: " + _name + " Nazwisko " + _surname + " Płeć " + Sex + " Miasto: " + _city + " Adres: " + _street + _flatNumber + " Wynagrodzenie: " + _salary + "Pozycja" + _position);
        }

        public void ChangePosition(string changedPosition)
        {
            Console.WriteLine(_name + " " + _surname + " zmienił pozycję na: " + changedPosition); 
        }



    }




}
