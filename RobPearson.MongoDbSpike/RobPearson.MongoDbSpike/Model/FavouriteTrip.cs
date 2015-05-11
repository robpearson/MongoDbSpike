namespace RobPearson.MongoDbSpike.Model
{
    public class FavouriteTrip
    {
        public string TripId { get; set; }
        public string DepartingStopId { get; set; }
        public string DepartingChildStopIds { get; set; }
        public string DepartingStopName { get; set; }
        public string DepartingLocation { get; set; }
        public string ArrivingStopId { get; set; }
        public string ArrivingChildStopIds { get; set; }
        public string ArrivingLocation { get; set; }
        public string ArrivingStopName { get; set; }
    }
}