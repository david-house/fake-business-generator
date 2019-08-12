using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BusinessNameGenerator.Models;

namespace BusinessNameGenerator
{
    public class FakeBusinessWriter
    {
        public static void WriteRecords(NameComponentSources nameComponentSources, int count, string outputPath)
        {
            using (var writer = new StreamWriter(outputPath))
            {
                writer.WriteLine("Name1\tName2\tName3\tCity\tState\tZIPCode\tSurname1\tSurname2\tFormOfBusiness\tPrefix\tSuffix\tPlaceName");

                for (int i = 0; i < count; i++)
                {
                    var bnc = nameComponentSources.GenerateNewBusinessName();
                    var recordComponents = new string[]
                    {
                        bnc[0],
                        bnc[1],
                        bnc[2],
                        bnc.PlaceName.ZipCity,
                        bnc.PlaceName.ZipState,
                        bnc.PlaceName.ZipCode,
                        bnc.Surname1,
                        bnc.Surname2,
                        bnc.LegalWord,
                        bnc.Prefix,
                        bnc.Suffix,
                        bnc.PlaceName.Name
                    };

                    writer.WriteLine(String.Join('\t', recordComponents));
                }

                writer.Flush();
                writer.Close();
            }

        }
    }
}
