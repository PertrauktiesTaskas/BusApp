using System.Collections.Generic;

namespace BusDataHandler.Models
{
    public class Stop
    {
        public string Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<string> Stops { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
    }
}
