using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Plane = AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dateTimes = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dateTimes.Add(Flights[i].FlightDate);
                }
            }
            return dateTimes;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var item in Flights)
                    {
                        if (item.Destination == filterValue)
                        {
                            Console.WriteLine(item.FlightDate);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var item in Flights)
                    {
                        if (item.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                case "Departure":
                    foreach (var item in Flights)
                    {
                        if (item.Departure == (filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case "Flightid":
                    foreach (var item in Flights)
                    {
                        if (item.FlightId == int.Parse(filterValue))
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;

            }

        }
        public void ShowFlightDetails(Plane plane)
        {
            foreach (var item in Flights)
            {
                Console.WriteLine(item.Destination);
                Console.WriteLine(item.FlightDate);
            }
        }
        //public IEnumerable<DateTime> GetFlightDates1(string destination)
        //{
        //    var query = from f in Flights
        //                where f.Destination == destination
        //                select f.FlightDate;
        //    return query;




        //}
        public void ShowFlightDetails1(Plane plane)
        {
            var query = from f in Flights
                        where f.Plane == plane
                        select f;
            foreach (var item in query) { Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }


        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from f in Flights
                        where f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7)
                        select f;
            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query = from f in Flights
                        where f.Destination == destination
                        select f.EstimatedDuration;
            return query.Average();
        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query;


        }
        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from Traveller in flight.Passengers.OfType<Traveller>()
                        orderby Traveller.BirthDate
                        select Traveller;
            return query.Take(3);

        }
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var query = from f in Flights
                        group f by f.Destination;
            foreach (var item in query) {
                Console.WriteLine("Destination" + item.Key);
                foreach (var item2 in item)
                {

                    Console.WriteLine("Decollage :" + item2.FlightDate);
                }
            }
            return query;
        }

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;

       
        
          
        public ServiceFlight()

        {     //    FlightDetailsDel = ShowFlightDetails;
            //    DurationAverageDel = DurationAverage;
            FlightDetailsDel = p =>
            {

                var query = from f in Flights
                            where f.Plane == p
                            select f;
                foreach (var item in query)
                {
                    Console.WriteLine(item.FlightDate);
                    Console.WriteLine(item.Destination);
                }
            };










        }

        public IEnumerable<DateTime> GetFlightDates1(string destination)
        {
            var queryLambda = Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate);
            return queryLambda.ToList();
        }


        public void ShowFlightDetails3(Plane plane)
        {
            var queryLambda = Flights.Where(f => f.Plane == plane).Select(f => f);
            foreach (var item in queryLambda)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }

        public IEnumerable<DateTime> GetFlightdates(string destination)
        {
            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.FlightDate;
            //return query;

            var queryLambda = Flights.Where(f => f.Destination == destination)
                                     .Select(f => f.FlightDate);
            return queryLambda.ToList();
        }

        public int ProgrammedFlightNumber2(DateTime startDate)
        {
            //var query = from flight in Flights
            //            where flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7)
            //            select flight;
            //return query.Count();
            var queryLambda = Flights.Where(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7))
                                     .Count();
            return queryLambda;
        }

        public void ShowFlightDetails2(Plane plane)
        {
            //var query = from flight in Flights
            //            where flight.Plane == plane
            //            select flight;

            var queryLambda = Flights.Where(f => f.Plane == plane)
                .Select(f => f);

            foreach (var item in queryLambda)
            {
                Console.WriteLine(item.FlightDate);
                Console.WriteLine(item.Destination);
            }
        }
        public double DurationAverage2(string destination)
        {
            //var query = from flight in Flights
            //            where flight.Destination == destination
            //            select flight.EstimatedDuration;
            //return query.Average();

            var queryLambda = Flights.Where((f) => f.Destination == destination)
                    .Select(f => f.EstimatedDuration);
            return queryLambda.Average();

        }
        public IEnumerable<Flight> OrderedDurationFlights2()
        {
            //var query = from flight in Flights
            //            orderby flight.EstimatedDuration descending
            //            select flight;
            //return query;

            var queryLambda = Flights.OrderByDescending(f => f.EstimatedDuration);
            return queryLambda.ToList();
        }

        public IEnumerable<Traveller> SeniorTravellers2(Flight flight)
        {
            //var query = from traveler in flight.Passengers.OfType<Traveller>()
            //            orderby traveler.BirthDate
            //            select traveler;
            //return query.Take(3);

            var queryLambda = flight.Passengers.OfType<Traveller>().OrderBy(t => t.BirthDate)
                .Select(t => t);
            return queryLambda.ToList();
        }

        public Action<Plane> FlightDetailsDel9;
        public Func<string, double> DurationAverageDel9;


        //FlightDetailsDel = ShowFlightDetails;
        //DurationAverageDel = DurationAverage;
     
    }

}


    

       

