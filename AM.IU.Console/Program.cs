// See https://aka.ms/new-console-template for more information


using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");
//Plane p1= new Plane();
//p1.Capacity = 200;
//p1.PlaneId= 1;
//p1.ManifactureDate = new DateTime(2023, 02, 02);
//p1.PlaneType = PlaneType.Boing;

//Plane p2 = new Plane(PlaneType.Airbus,200,DateTime.Now);
Plane p3 = new Plane()
{
    PlaneType = PlaneType.Boing,
    Capacity= 100,
    ManifactureDate= DateTime.Now
}
;
Passenger passenger1 = new Passenger()
{
    FirstName = "abcs",
    LastName = "zehd",
    EmailAdress = "abc@gmail.com"
};
Console.WriteLine(passenger1.CheckProfile("abcs", "zehd", "abc@gmail1.com"));
Traveller Traveller1 = new Traveller()
{
    FirstName = "abcs",
    LastName = "zehd",
    EmailAdress = "abc@gmail.com"
};
Staff staff1 = new Staff()
{

    FirstName = "abcs1",
    LastName = "zehd1",
    EmailAdress = "abc2@gmail.com"
};
Console.WriteLine("méthode passenger type pour Staff1");
staff1.PassengerType();
Console.WriteLine("méthode passenger type pour Traveller1"); 
Traveller1.PassengerType();
Console.WriteLine("méthode passenger type pour Passenger1"); 
passenger1.PassengerType();