# MongoDbSpike
Simple Spike to explore MongoDB.

## Goals

Exploring NoSQL and MongoDB by trying to implement saving/retrieving data from hitting some fictional example endpoints.

- [ ] https://api.maplepixel.io/transit/timetables/2015-05-02 - GET Transit timetables
- [x] https://api.maplepixel.io/settings/favouritetrip/ - POST to save a new favourite trip
- [x] https://api.maplepixel.io/settings/favouritetrip/1 - GET to retrieve an existing favourite trip

Interested to see how easy it is to define the data model (if needed) and time to persist/retrieve data.

Update: Implemented `SettingsRepository` to explore saving and retrieving entities and it works pretty well.  Further work on a composite/complex entity would be good in the future.

## Requirements

Built w/ Microsoft Visual Studio 2013 and .NET 4.5.  Using NUnit 2.x and Moq for testing.

## Credits

MongoDbSpike was created by [Rob Pearson](http://twitter.com/robpearson) at [Maple Pixel Pty. Ltd.](http://maplepixel.com.au).

## License

MongoDbSpike is available under the MIT license. See the LICENSE file for more info.
