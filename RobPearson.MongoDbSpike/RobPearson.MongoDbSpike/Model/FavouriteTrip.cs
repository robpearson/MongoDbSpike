using MongoDB.Bson;

namespace RobPearson.MongoDbSpike.Model
{
    public class FavouriteTrip
    {
        public const string ModelName = "FavouriteTrip";

        public ObjectId Id { get; set; }
        public string FavouriteTripId { get; set; }
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