﻿namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("Less than 3 items in input");
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var lat = double.Parse(cells[0]);

            // grab the longitude from your array at index 1
            var lon = double.Parse(cells[1]);

            // grab the name from your array at index 2
            var tacoBellName = cells[2];

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`---DONE

            // You'll need to create a TacoBell class
            // that conforms to ITrackable---DONE

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var locationPoint = new Point();
            locationPoint.Latitude = lat;
            locationPoint.Longitude = lon;

            var tacoBell = new TacoBell()
            {
                Name = tacoBellName,
                Location = locationPoint
            };

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell;

            
        }
    }
}