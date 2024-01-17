using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_2Dziedziczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student
        }

        class Address
        {
            public Address(string city, string street, string housenumber, string postalcode)
            {
                City = city;
                Street = street;
                HouseNumber = housenumber;
                PostalCode = postalcode;
            }

            public string City { get; set; }
            public string Street { get; set; }

            public string PostalCode { get; set; }
            public string HouseNumber { get; set; }


        }
        class Person
        {
            public string Name {  get; set; }
            public string Surname { get; set; }

            public DateTime DateOfBirth { get; set; }

            public byte Age {
                get
                {
                    TimeSpan difference = DateTime.Now - DateOfBirth;
                    return (byte)(difference.Days /365.25);
                }
            }


            public Person(string name, string surname, DateTime date,Address address)
            {
                Name = name;
                Surname = surname;
                DateOfBirth = date;
                Address = address;
            }

            public Address Address { get; set; }

            public string GetFullName()
            {
                return $"Imie i nazwisko: {Name} {Surname}";
            }
        }

        class Student : Person
        {
            public int studentNumber { get; set; }
            public Student(string name, string surname, DateTime date, Address address, int studentNumber) : base(name, surname, date, address)
            {
                this.studentNumber = studentNumber;
            }
        }
    }
}
/*
 * Dziedziczenie – zadanie 1
 Napisz program w języku C#, który ilustruje pojęcia programowania obiektowego,
takie jak klasy, dziedziczenie, właściwości i metody.
 Zdefiniuj klasę bazową Person, która ma pola Name, Surname i DateOfBirth oraz
konstruktor przyjmujący te wartości jako parametry.
 Dodaj do klasy Person metodę GetFullName, która zwraca pełne imię i nazwisko
osoby oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
 Zdefiniuj klasę Address, która ma pola City, Street, HouseNumber i PostalCode jako
właściwości oraz konstruktor przyjmujący te wartości jako parametry.
 Dodaj do klasy Person pole Address typu Address i zmodyfikuj konstruktor klasy
Person, aby przyjmował obiekt klasy Address jako parametr.
 Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe
pole studentNumber oraz konstruktor przyjmujący te wartości jako parametry.
 Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe
pole subjects typu List<string> oraz konstruktor przyjmujący te wartości jako
parametry.
 Utwórz obiekty każdej klasy, używając słowa kluczowego new i podając odpowiednie
wartości w konstruktorach.
 Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
właściwości obiektów.

*/