using System;

namespace GeoApp.Model
{
    public class GeoObject
    {
        public Guid Id { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public double Accuracy { get; set; }

        public DateTime MeasurementDateTime { get; set; }
    }
}
