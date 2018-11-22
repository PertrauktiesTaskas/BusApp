using BusDataHandler.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BusDataHandler
{
    public class BusDataHandler
    {
        private string dataFilePath;

        public BusDataHandler()
        {
            dataFilePath = "";
        }

        public BusDataHandler(string dataFilePath)
        {
            this.dataFilePath = dataFilePath;
        }

        public List<Stop> ParseStops()
        {
            var stops = new List<Stop>();
            string file = File.ReadAllText(dataFilePath);
            var bracketRegex = new Regex(@"\((.*?)\)");
            var stops_txt = bracketRegex.Match(file).ToString();
            var stops_txt_split = stops_txt.Split("\\na").ToList().Skip(1);
            try
            {
                foreach (var line in stops_txt_split)
                {

                    var elements = line.Split(";");
                    var e_stops = elements[3].Split(",");
                    stops.Add(new Stop
                    {
                        Id = elements[0],
                        Latitude = elements[1],
                        Longitude = elements[2],
                        Stops = new List<string>(e_stops),
                        City = elements[4],
                        Street = elements.Length < 7 ? "" : elements[6],
                        Country = elements.Length < 8 ? "" : elements[7],
                        CountryCode = elements.Length < 9 ? "" : elements[8]
                    });
                }
            }
            catch (System.Exception ex)
            {

            }
            return stops;
        }
    }
}
