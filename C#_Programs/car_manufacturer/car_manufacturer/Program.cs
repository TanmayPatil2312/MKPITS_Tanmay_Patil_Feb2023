using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manufacturer
{
    class manufacturer
    {
        protected int price;
    }
    class dealer:manufacturer
    {
        string company;
        string name;
        int year;
        public void getdata(string name , int year , string company)
        {
            this.name = name;
            this.year = year;
            this.company= company;
        }
        public void displaydata()
        {
            Console.WriteLine("Company Name :- " + company);
            Console.WriteLine("Car Name :- " + name);
            Console.WriteLine("Manufacturing Year :- " + year);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dealer car = new dealer();
            car.getdata("Thar", 2023 , "Mahindra");
            car.displaydata();
            Console.ReadKey();
        }
    }
}
