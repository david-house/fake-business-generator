using System;
using System.Collections.Generic;
using System.IO;
using BusinessNameGenerator.Models;
using System.Diagnostics;

namespace BusinessNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var businesses = new List<BusinessNameComponents>();

            var nameComponentSources = new NameComponentSources()
            {
                PlaceNames = PlaceNameLoader.Load("Data/place_names.txt"),
                Surnames = SurnameLoader.Load("Data/surnames_us.txt"),
                Suffixes = File.ReadAllLines("Data/business_suffixes.txt"),
                Prefixes = File.ReadAllLines("Data/business_prefixes.txt"),
                FormsOfBusiness = File.ReadAllLines("Data/legal_control_words.txt")
            };

            var sw = Stopwatch.StartNew();
            int n = 10000000;

            FakeBusinessWriter.WriteRecords(nameComponentSources, n, "output.txt");

            sw.Stop();
            Console.WriteLine($"Created {n} businesses in {sw.ElapsedMilliseconds}ms");
        }
    }
}
