using System;
using System.IO;
using BusinessNameGenerator.Models;

namespace BusinessNameGenerator
{
    class Program
    {
        static string 
        static void Main(string[] args)
        {
            var placeNames = PlaceNameLoader.Load("Data/place_names.txt");
            var numberOfPlaceNames = placeNames.Length;

            var surnames = SurnameLoader.Load("Data/surnames_us.txt");
            var numberOfSurnames = surnames.Length;

            var suffixes = File.ReadAllLines("Data/business_suffixes.txt");
            var numberOfSuffixes = suffixes.Length;

            var prefixes = File.ReadAllLines("Data/business_prefixes.txt");
            var numberOfPrefixes = prefixes.Length;

            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                var placeName = placeNames[random.Next(numberOfPlaceNames)];
                var surname = surnames[random.Next(numberOfSurnames)];
                var suffix = suffixes[random.Next(numberOfSuffixes)];
                var prefix = prefixes[random.Next(numberOfPrefixes)];
                Console.WriteLine($"{placeName}, {surname}, {suffix}, {prefix}");
            }
        }
    }
}
