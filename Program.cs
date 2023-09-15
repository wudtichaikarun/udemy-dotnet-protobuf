using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Course.Protobuf.Test;

Console.WriteLine("Welcome to Protobuf test!");
var emp = new Employee();
emp.FirstName = "Ro";
emp.LastName = "Mantic";
emp.IsRetired = false;
var birthdate = new DateTime(1989, 7, 9);
birthdate = DateTime.SpecifyKind(birthdate, DateTimeKind.Utc);
emp.BirthDate = Timestamp.FromDateTime(birthdate);
// it will error Employee' does not contain a definition for 'Age'
// because file will generate after run code
emp.Age = 28;
emp.MaritalStatus = Employee.Types.MaritalStatus.Single;
emp.PreviousEmployers.Add("Microosoft");
emp.PreviousEmployers.Add("Apple");
// composition types
emp.CurrentAddress = new Address();
emp.CurrentAddress.City = "New York";
emp.CurrentAddress.StreetName = "Sth Avenue";
emp.CurrentAddress.HouseNumber = 101;
// using map
// Map = Hashtable = Dictionary
emp.Relatives.Add("father", "John");
emp.Relatives.Add("mother", "Hannah");
emp.Relatives.Add("brother", "Dirk");

using (var output = File.Create("emp.dat"))
{
  emp.WriteTo(output);
}

Employee empFromFile;
using (var input = File.OpenRead("emp.dat"))
{
  empFromFile = Employee.Parser.ParseFrom(input);
}


Console.WriteLine("Protobuf test complete");