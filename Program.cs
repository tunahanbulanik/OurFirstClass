using System;
using System.Threading.Channels;
namespace OurFirstClass
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

        public Person(string ad, string soyad, DateTime dogumTarihi)
        {
            Name = ad;
            LastName = soyad;
            BirthDay = dogumTarihi;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}, Doğum Tarihi: {BirthDay.ToShortDateString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person studentOne = new Person("Tuna","Bulanık", new DateTime(1999 , 7 , 13));
            Person studentTwo = new Person("Ahmet", "Ahmetoğlu", new DateTime(2003 , 9, 18));

            Console.WriteLine("Öğrenciler:");
            Console.WriteLine($"{studentOne} \n {studentTwo}");
        }
    }
}