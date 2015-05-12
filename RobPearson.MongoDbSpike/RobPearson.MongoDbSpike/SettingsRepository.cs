using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using MongoDB.Driver;
using RobPearson.MongoDbSpike.Model;

namespace RobPearson.MongoDbSpike
{
    public interface ISettingsRepository
    {
        IEnumerable<FavouriteTrip> GetAllFavouritesTrips();
        FavouriteTrip GetFavouriteTripById(int id);
        Task<string> SaveFavouriteTrip(FavouriteTrip trip);
    }

    public class SettingsRepository : ISettingsRepository
    {
        private readonly string connectionString;
        
        public const string DatabaseName = "SpikeDB";
        private const string FavouriteTripModelName = "FavouriteTrip";

        public SettingsRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SpikeDB.Prod"].ConnectionString;
        }

        public SettingsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<FavouriteTrip> GetAllFavouritesTrips()
        {
            return null;
        }

        public FavouriteTrip GetFavouriteTripById(int id)
        {
            return null;
        }

        public async Task<string> SaveFavouriteTrip(FavouriteTrip favouriteTrip)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<FavouriteTrip>(FavouriteTripModelName);
            await collection.InsertOneAsync(favouriteTrip);
            return favouriteTrip.Id.ToString();
        }
    }
}