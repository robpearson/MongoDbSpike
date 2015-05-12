using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using MongoDB.Driver;
using RobPearson.MongoDbSpike.Model;

namespace RobPearson.MongoDbSpike
{
    public interface ISettingsRepository
    {
        Task<IEnumerable<FavouriteTrip>> GetAllFavouritesTrips();
        Task<FavouriteTrip> GetFavouriteTripById(string id);
        Task<string> SaveFavouriteTrip(FavouriteTrip trip);
    }

    public class SettingsRepository : ISettingsRepository
    {
        private readonly string connectionString;

        public const string DatabaseName = "spikedb";

        public SettingsRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SpikeDB.Prod"].ConnectionString;
        }

        public SettingsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<IEnumerable<FavouriteTrip>> GetAllFavouritesTrips()
        {
            var dbCollection = GetDbCollection();
            var favourites = await dbCollection.Find(x => x.FavouriteTripId != null).ToListAsync();
            return favourites;
        }

        public async Task<FavouriteTrip> GetFavouriteTripById(string id)
        {
            var dbCollection = GetDbCollection();
            var favourite = await dbCollection.Find(c => c.FavouriteTripId == id).FirstOrDefaultAsync();
            return favourite;
        }

        public async Task<string> SaveFavouriteTrip(FavouriteTrip favouriteTrip)
        {
            var dbCollection = GetDbCollection();
            await dbCollection.InsertOneAsync(favouriteTrip);
            return favouriteTrip.Id.ToString();
        }

        private IMongoCollection<FavouriteTrip> GetDbCollection()
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<FavouriteTrip>(FavouriteTrip.ModelName);
            return collection;
        }
    }
}