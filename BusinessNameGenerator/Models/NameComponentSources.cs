using System;
using System.Collections.Generic;

namespace BusinessNameGenerator.Models
{
    public class NameComponentSources
    {
        public PlaceName[] PlaceNames { get; set; }
        public string[] Surnames { get; set; }
        public string[] Suffixes { get; set; }
        public string[] Prefixes { get; set; }
        public string[] FormsOfBusiness { get; set; }
        public Dictionary<string, HashSet<string>> NamesUsedByState = new Dictionary<string, HashSet<string>>();
        public Dictionary<string, HashSet<string>> NamesUsedByZipCode = new Dictionary<string, HashSet<string>>();

        private bool AddIfUnique(BusinessNameComponents businessNameComponents)
        {
            businessNameComponents.Tries++;

            var state = businessNameComponents.PlaceName.ZipState;
            var zipCode = businessNameComponents.PlaceName.ZipCode;

            if (!NamesUsedByState.ContainsKey(state))
                NamesUsedByState[state] = new HashSet<string>();
            var namesForState = NamesUsedByState[state];

            if (!NamesUsedByZipCode.ContainsKey(zipCode))
                NamesUsedByZipCode[zipCode] = new HashSet<string>();
            var namesForZipCode = NamesUsedByZipCode[zipCode];

            if (namesForState.Contains(businessNameComponents[0]) ||
                namesForZipCode.Contains(businessNameComponents[1]))
                return false;

            namesForState.Add(businessNameComponents[0]);
            namesForZipCode.Add(businessNameComponents[1]);

            return true;
        }

        private Random Random { get; } = new Random();

        public BusinessNameComponents GenerateNewBusinessName()
        {
            while (true)
            {
                var bnc = GetRandomBusinessName();

                if (AddIfUnique(bnc))
                    return bnc;
            }


        }

        private BusinessNameComponents GetRandomBusinessName()
        {
            return new BusinessNameComponents()
            {
                PlaceName = PlaceNames[Random.Next(PlaceNames.Length)],
                Surname1 = Surnames[Random.Next(Surnames.Length)],
                Surname2 = Surnames[Random.Next(Surnames.Length)],
                Prefix = Prefixes[Random.Next(Prefixes.Length)],
                Suffix = Suffixes[Random.Next(Suffixes.Length)],
                LegalWord = FormsOfBusiness[Random.Next(FormsOfBusiness.Length)],
                NameTemplateIds = new int[]
                {
                    Random.Next(5),
                    Random.Next(5),
                    Random.Next(5)
                }
            };

            
        }
    }
}
