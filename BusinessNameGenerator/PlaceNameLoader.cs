using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using BusinessNameGenerator.Models;

namespace BusinessNameGenerator
{
    public static class PlaceNameLoader
    {
        public static PlaceName[] Load(string path)
        {
            return File.ReadLines(path)
                .Skip(1)
                .Select(row => new PlaceName(row.Split('\t')))
                .ToArray();
        }
    }
}
