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

        public PlaceName(string name, string state, float latitude, float longitude, string zipCode, string zipState, string zipCity)
        {
            Name = name;
            State = state;
            Latitude = latitude;
            Longitude = longitude;
            ZipCode = zipCode;
            ZipState = zipState;
            ZipCity = zipCity;
        }

    }
}