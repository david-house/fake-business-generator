using System;
using System.Globalization;
using System.IO;
using System.Runtime.ExceptionServices;
using BusinessNameGenerator.Models;

namespace BusinessNameGenerator
{
    class Program
    {
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

            var formsOfBusiness = File.ReadAllLines("Data/legal_control_words.txt");
            var numberOfFormsOfBusiness = formsOfBusiness.Length;

            var random = new Random();
            

            for (int i = 0; i < 100; i++)
            {
                var businessName = new BusinessNameComponents()
                {
                    PlaceName = placeNames[random.Next(numberOfPlaceNames)].Name,
                    Surname1 = surnames[random.Next(numberOfSurnames)],
                    Surname2 = surnames[random.Next(numberOfSurnames)],
                    Prefix = prefixes[random.Next(numberOfPrefixes)],
                    Suffix = suffixes[random.Next(numberOfSuffixes)],
                    LegalWord = formsOfBusiness[random.Next(numberOfFormsOfBusiness)],
                    NameTemplateIds = new int[]
                    {
                        random.Next(5),
                        random.Next(5),
                        random.Next(5)
                    }
                };

 

                Console.WriteLine($"{businessName[0]} {businessName[1]} {businessName[2]}");
            }
        }
    }
}
