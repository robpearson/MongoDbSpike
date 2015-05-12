using System;
using System.Configuration;
using System.Threading.Tasks;
using MongoDB.Driver;
using RobPearson.MongoDbSpike.Model;

namespace RobPearson.MongoDbSpike
{
    public interface ITransitTimetableRepository
    {
        Task<IAsyncCursor<TransitTripDetail>> GetTimetable(DateTime date);
        Task<string> Save(TransitTripDetail trip);
    }

    public class TransitTimetableRepository : ITransitTimetableRepository
    {
        private string connectionString;
        public const string DatabaseName = "SpikeDB";

        public TransitTimetableRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SpikeDB.Prod"].ConnectionString;
        }

        public TransitTimetableRepository(string connectionString)
        {
            this.connectionString = "mongodb://spikeuser:cieqi6xKaNCr2HfvVNzB@ds063809.mongolab.com:63809/spikedb";
        }

        public async Task<IAsyncCursor<TransitTripDetail>> GetTimetable(DateTime date)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<TransitTripDetail>("trip");
            return await collection.FindAsync(x => x.Id != null);
        }

        public async Task<string> Save(TransitTripDetail trip)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(DatabaseName);
            var collection = database.GetCollection<TransitTripDetail>("trip");
            await collection.InsertOneAsync(trip);
            return trip.Id.ToString();
        }
    }
}