using System;

namespace BusinessNameGenerator.Models
{

    public class PlaceName
    {
        public string Name { get; set; }
        public string State { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string ZipCode { get; set; }
        public string ZipState { get; set; }
        public string ZipCity { get; set; }

        public PlaceName() { }

        public PlaceName(string[] elements)
        {
            Name = elements[0];
            State = elements[1];
            Latitude = Convert.ToSingle(elements[2]);
            Longitude = Convert.ToSingle(elements[3]);
            ZipCode = elements[4];
            ZipState = elements[5];
            ZipCity = elements[6];
        }

        public override string ToString()
        {
            return $"{Name}, {State}";
        }

    }
}