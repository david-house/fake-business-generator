using System;
using System.IO;
using BusinessNameGenerator.Models;
using System.Diagnostics;

namespace BusinessNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputPath = "output.txt";
            var n = 10000000;

            var nameComponentSources = new NameComponentSources()
            {
                PlaceNames = PlaceNameLoader.Load("Data/place_names.txt"),
                Surnames = SurnameLoader.Load("Data/surnames_us.txt"),
                Suffixes = File.ReadAllLines("Data/business_suffixes.txt"),
                Prefixes = File.ReadAllLines("Data/business_prefixes.txt"),
                FormsOfBusiness = File.ReadAllLines("Data/legal_control_words.txt")
            };

            var sw = Stopwatch.StartNew();
            FakeBusinessWriter.WriteRecords(nameComponentSources, n, outputPath);
            sw.Stop();

            Console.WriteLine($"Created {n} businesses in {sw.ElapsedMilliseconds}ms");
        }
    }
}
