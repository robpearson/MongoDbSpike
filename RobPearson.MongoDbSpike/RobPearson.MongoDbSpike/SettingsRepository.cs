using System.Collections.Generic;
using RobPearson.MongoDbSpike.Model;

namespace RobPearson.MongoDbSpike
{
    public interface ISettingsRepository
    {
        IEnumerable<FavouriteTrip> GetAllFavouritesTrips();
        FavouriteTrip GetFavouriteTripById(int id);
        int SaveFavouriteTrip(FavouriteTrip trip);
    }

    public class SettingsRepository : ISettingsRepository
    {
        public IEnumerable<FavouriteTrip> GetAllFavouritesTrips()
        {
            return null;
        }

        public FavouriteTrip GetFavouriteTripById(int id)
        {
            return null;
        }

        public int SaveFavouriteTrip(FavouriteTrip trip)
        {
            return 1;
        }
    }
}