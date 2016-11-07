using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Car :  Vehicle, IRideable, IComparable<Car>
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }

        //deklaracja pól w klasie
        private int year; //rok produkcji
        private string brand; //marka

        //konstruktor z parametrami
        public Car(int year, string brand)
        {
            this.year = year;
            this.brand = brand;
        }

        //konstruktor domyslny
        public Car()
        {

        }

        //metoda zwracająca rok
        public int GetYear()
        {
            return year;

        }

        //metoda zwracajaca marke
        public string GetBrand()
        {
            return brand;
        }

       //definicja porównywania
        public int CompareTo(Car other)
        {
            if (this.year == other.year)
            {
                return other.brand.CompareTo(this.brand);
            }
            return other.year.CompareTo(this.year);
        }
    }
}
