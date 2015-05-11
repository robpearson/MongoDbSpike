using System;

namespace RobPearson.MongoDbSpike.Model
{
    public class TransitTripDetail
    {
        public string RouteShortName { get; set; }
        public string RouteLongName { get; set; }
        public string DepartingStopName { get; set; }
        public string DepartingPlatform { get; set; }
        public DateTime DepartingTime { get; set; }
        public string DepartingLocation { get; set; }
        public string ArrivingStopName { get; set; }
        public string ArrivingPlatform { get; set; }
        public DateTime ArrivingTime { get; set; }
        public string ArrivingLocation { get; set; }
    }
}