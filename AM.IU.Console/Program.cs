// See https://aka.ms/new-console-template for more information


using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
//Plane p1= new Plane();
//p1.Capacity = 200;
//p1.PlaneId= 1;
//p1.ManifactureDate = new DateTime(2023, 02, 02);
//p1.PlaneType = PlaneType.Boing;

//Plane p2 = new Plane(PlaneType.Airbus,200,DateTime.Now);
//Plane p3 = new Plane()
//{
//    PlaneType = PlaneType.Boing,
//    Capacity= 100,
//    ManifactureDate= DateTime.Now
//}
//;
//Passenger passenger1 = new Passenger()
//{
//    FirstName = "abcs",
//    LastName = "zehd",
//    EmailAdress = "abc@gmail.com"
//};
//Console.WriteLine(passenger1.CheckProfile("abcs", "zehd", "abc@gmail1.com"));
//Traveller Traveller1 = new Traveller()
//{
//    FirstName = "abcs",
//    LastName = "zehd",
//    EmailAdress = "abc@gmail.com"
//};
//Staff staff1 = new Staff()
//{

//    FirstName = "abcs1",
//    LastName = "zehd1",
//    EmailAdress = "abc2@gmail.com"
//};
//Console.WriteLine("méthode passenger type pour Staff1");
//staff1.PassengerType();
//Console.WriteLine("méthode passenger type pour Traveller1"); 
//Traveller1.PassengerType();
//Console.WriteLine("méthode passenger type pour Passenger1"); 
//passenger1.PassengerType();
//ServiceFlight sf = new ServiceFlight();
//sf.Flights = TestData.listFlights;
//foreach(var item in sf.GetFlightDates("Paris")){
//    Console.WriteLine(item);
//}
//ServiceFlight flightService1 = new ServiceFlight();
//flightService1.Flights = TestData.listFlights;
//List<DateTime> mylist = flightService1.GetFlightDates("Paris");
//for (int i = 0; i < mylist.Count; i++)
//{
//    Console.WriteLine("la date est: " + mylist[i]);
//}

ServiceFlight s = new ServiceFlight();
s.Flights = TestData.listFlights;
s.GetFlights("Destination", "Paris");
ServiceFlight ss = new ServiceFlight();
ss.Flights = TestData.listFlights;
foreach (var flight in s.GetFlightDates1("Paris")){ 
    Console.WriteLine(flight);
}
ServiceFlight s1 = new ServiceFlight();
s1.Flights = TestData.listFlights;
s1.DestinationGroupedFlights();


