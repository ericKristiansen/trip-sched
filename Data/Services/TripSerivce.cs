
using System.Linq;
using System.Collections.Generic;

namespace Trips.Data
{
    public class TripService: ITripService
    {
        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId) => Data.Trips.FirstOrDefault(n => n.Id == tripId);

        public void AddTrip(Trip trip) => Data.Trips.Add(trip);

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);

            if (oldTrip != null)
            {
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = trip.DateStarted;
                oldTrip.DateCompleted = trip.DateCompleted;
            }
            else
            {
                System.Console.Out.WriteLine("Did not update. Trip was not found...");
            }
        }

        public void DeleteTrip(int tripId)
        {
            var trip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
            if (trip != null)
            {
                Data.Trips.Remove(trip);
            }
        }

    }
}