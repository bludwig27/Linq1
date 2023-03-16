using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Linq1
{
    public class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }
        
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
        };

Console.WriteLine("People with birthdates after 1900:");
            var myLinq1 = from s in stemPeople
                          where s.BirthYear > 1899
                          select s;
            foreach(var m in myLinq1) Console.WriteLine(m.Name);
            Console.WriteLine();
            Console.WriteLine("People with two 'l's in their name:");
            var myLinq2 = from s in stemPeople
                          where s.Name.Contains("ll")
                          select s;
            foreach(var m in myLinq2) Console.WriteLine(m.Name);
            Console.WriteLine();
            var myLinq3 = from s in stemPeople
                          where s.BirthYear > 1949
                          select s;
            Console.WriteLine($"{myLinq3.Count()} people were born in 1950 or later.");
            Console.WriteLine();
            Console.WriteLine("People who were born between 1920 and 2000, sorted by birth year:");
            var myLinq4 = from s in stemPeople
                          where(s.BirthYear > 1919 && s.BirthYear < 2001)
                          orderby s.BirthYear
                          select s;
            foreach (var m in myLinq4) Console.WriteLine(m.Name);
            Console.WriteLine($"{myLinq4.Count()} people are on this list.");
            Console.WriteLine();
            Console.WriteLine("Finally, people who died between 1960 and 2015, sorted by name:");
            var myLinq5 = from s in stemPeople
                          where s.DeathYear > 1959 && s.DeathYear < 2016
                          orderby s.Name
                          select s;
            foreach (var m in myLinq5) Console.WriteLine(m.Name);
            Console.WriteLine("I guess the sorting doesn't matter since there's only one, though!");
        }

    }
}
