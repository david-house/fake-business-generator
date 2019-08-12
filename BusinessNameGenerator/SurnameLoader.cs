using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using BusinessNameGenerator.Models;

namespace BusinessNameGenerator
{
    public static class SurnameLoader
    {
        public static string[] Load(string path)
        {
            var textInfo = new CultureInfo("en-US", false).TextInfo;

            return File.ReadLines(path)
                .Skip(1)
                .Select(row => textInfo.ToTitleCase(row.Split('\t')[0].ToLower()))
                .ToArray();
        }
    }
}
