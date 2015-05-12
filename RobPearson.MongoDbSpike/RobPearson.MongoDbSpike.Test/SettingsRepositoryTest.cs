using System;
using NUnit.Framework;
using RobPearson.MongoDbSpike.Model;

namespace RobPearson.MongoDbSpike.Test
{
    [TestFixture]
    public class SettingsRepositoryTest
    {
        private const string ConnectionString = "mongodb://test:FVjDCpoG2uJsqAvxdg4C@ds063809.mongolab.com:63809/spikedb";

        [Test]
        public void Given_Invalid_Id_Then_Returns_Null_FavouriteTrip()
        {
            // Given
            var repo = new SettingsRepository(ConnectionString);

            // When / Then
            Assert.That(async () => await repo.GetFavouriteTripById(Guid.Empty.ToString()), Is.Null);
        }

        [Test]
        public void Given_Favourite_Trip_Then_Can_Save_And_Retrieve_Fav()
        {
            // Given
            var fav = new FavouriteTrip
            {
                FavouriteTripId = Guid.NewGuid().ToString(),
                DepartingStopId = "1234",
                DepartingChildStopIds = "221, 224, 225",
                DepartingStopName = "Bald Hills",
                DepartingLocation = "12345.6, 5555.6",
                ArrivingStopId = "4533",
                ArrivingChildStopIds = "551, 552, 553, 554, 555, 556",
                ArrivingLocation = "1235.77, 98171.1",
                ArrivingStopName = "Central"
            };
            var repo = new SettingsRepository(ConnectionString);

            // When / Then 
            Assert.That(async () => await repo.SaveFavouriteTrip(fav), Is.TypeOf<string>().And.Not.Empty);
            Assert.That(async () => await repo.GetFavouriteTripById(fav.FavouriteTripId), Is.Not.Null);
        }

        [Test]
        public void Given_Empty_Favourite_Trip_Then_Saves_Empty_Fav()
        {
            // Given
            var repo = new SettingsRepository(ConnectionString);

            // When / Then
            Assert.That(async () => await repo.SaveFavouriteTrip(new FavouriteTrip()), Is.TypeOf<string>().And.Not.Empty);
        }
    }
}