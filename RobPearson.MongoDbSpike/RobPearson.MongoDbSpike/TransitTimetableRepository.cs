using System;
using System.Collections.Generic;
using RobPearson.MongoDbSpike.Model;

namespace RobPearson.MongoDbSpike
{
    public interface ITransitTimetableRepository
    {
        IEnumerable<TransitTripDetail> GetTimetable(DateTime date);
    }

    public class TransitTimetableRepository : ITransitTimetableRepository
    {
        public IEnumerable<TransitTripDetail> GetTimetable(DateTime date)
        {
            return null;
        }
    }
}