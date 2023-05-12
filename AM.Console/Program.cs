// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");

////constructeur par défaut
//Plane plane = new Plane();
//plane.Capacity = 300;
//plane.ManufactureDate = DateTime.Now;
//plane.PlaneType = PlaneType.Boing;
////Constructeur paramétré
//Plane plane2 = new Plane(PlaneType.Boing,new DateTime(2018,2,12),200);

//initialiseur d'objet 
Plane plane3 = new Plane
{
    Capacity = 100,
    ManufactureDate = DateTime.Now,
    PlaneType = PlaneType.Boing
    
};
Console.WriteLine("************************************ Testing Signature Polymorphisme ****************************** ");
//Passenger p1 = new Passenger { 
//    FullName = new FullName {
//        FirstName="steave",LastName="jobs"}
//    , EmailAddress = "steeve.jobs@gmail.com", BirthDate = new DateTime(1955, 01, 01) };
//Console.WriteLine("la méthode Checkpassenger");
//Console.WriteLine(p1.CheckProfile("Steave", "Jobs"));
//Console.WriteLine(p1.CheckProfile("steave", "jobs", "steeve.jobs@gmail"));

//Console.WriteLine("************************************ Testing Inheritance Polymorphisme ****************************** ");
//Staff s1 = new Staff {PassportNumber="2", FirstName = "Bill", LastName = "Gates", EmailAddress = "Bill.gates@gmail.com", BirthDate = new DateTime(1945, 01, 01), EmployementDate = new DateTime(1990, 01, 01), Salary = 99999 };
//Traveller t1 = new Traveller { FirstName = "Mark", LastName = "Zuckerburg", EmailAddress = "Mark.Zuckerburg@gmail.com", BirthDate = new DateTime(1980, 01, 01), HealthInformation = "Some troubles", Nationality = "American" };
//p1.PassengerType();
//s1.PassengerType();
//t1.PassengerType();

//Console.WriteLine("************************************ Testing Services  ****************************** ");
//ServiceFlight sf = new ServiceFlight();

//sf.Flights = TestData.listFlights;

//Console.WriteLine("************************************ GetFlightDates (string destination)  ****************************** ");
//Console.WriteLine("Flight dates to Madrid");
//foreach (var item in sf.GetFlightDates("Madrid"))
//    Console.WriteLine(item);
//Console.WriteLine("************************************ GetFlights(string filterType, string filterValue)  ****************************** ");
//sf.GetFlights("Destination", "Paris");
//Console.WriteLine("************************************ ShowFlightDetails(Plane plane)  ****************************** ");
//sf.ShowFlightDetails(TestData.Airbusplane);
//Console.WriteLine("************************************ ProgrammedFlightNumber(DateTime startDate)  ****************************** ");
//Console.WriteLine("Number of programmed flights in 01/01/2022 week: ");
//sf.ProgrammedFlightNumber(new DateTime(2022, 01, 01));
//Console.WriteLine("************************************ DurationAverage(string destination) ****************************** ");
//Console.WriteLine("Duration average of flights to Madrid: " + sf.DurationAverage("Madrid"));
//Console.WriteLine("************************************ OrderedDurationFlights()  ****************************** ");
//foreach (var item in sf.OrderedDurationFlights())
//    Console.WriteLine(item);
//Console.WriteLine("************************************ SeniorTravellers(Flight flight) ****************************** ");
//foreach (var item in sf.SeniorTravellers(TestData.flight1))
//    Console.WriteLine(item);
//Console.WriteLine("************************************ DestinationGroupedFlights()  ****************************** ");
//sf.diplay();

//Console.WriteLine("************************************ Testing Delegates  ****************************** ");

//sf.FlightDetailsDel(TestData.BoingPlane);
//Console.WriteLine("Average duration of flight To Paris; " + sf.DurationAverageDel("Paris"));


//Console.WriteLine("************************************ Testing Extension methods  ****************************** ");
//p1.UpperFullName();
//Console.WriteLine("First Name: " + p1.FirstName + " Last Name: " + p1.LastName);

//Plane p = new Plane();
Plane plane1 = new Plane
{
    PlaneType = PlaneType.Airbus,
    Capacity = 150,
    ManufactureDate = new DateTime(2015, 02, 03)
};

Flight f1 = new Flight()
{
    Departure = "Tunis",
    AirlineLogo = "Tunisair",
    FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
    Destination = "Paris",
    EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
    EstimatedDuration = 105,
    Plane = plane1
};

AMContext am = new AMContext();
//am.Planes.Add(plane3);
//am.Flights.Add(f1);
//am.Planes.Add(TestData.BoingPlane);//ajouter s1 dans le dbset
//am.Staffs.Add(s1);
am.SaveChanges();

Console.WriteLine(f1.Plane.PlaneId+ f1.Plane.Capacity);
Console.WriteLine(plane3.PlaneId + plane3.Capacity);





