﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BusinessNameGenerator.Models;

namespace BusinessNameGenerator
{
    public static class SurnameLoader
    {
        public static string[] Load(string path)
        {
            return File.ReadLines(path)
                .Skip(1)
                .Select(row => row.Split('\t')[0])
                .ToArray();
        }
    }
}