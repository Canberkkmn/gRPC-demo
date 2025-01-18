using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Protobuf.test;

Console.WriteLine("Welcome to Protobuf!");
var emp = new Employee();
emp.FirstName = "Canberk";
emp.LastName = "Kaman";
emp.IsRetired = false;
var birthdate = new DateTime(1996, 2, 12);
birthdate = DateTime.SpecifyKind(birthdate, DateTimeKind.Utc);
emp.BirthDate = Timestamp.FromDateTime(birthdate);
emp.MaritalStatus = Employee.Types.MaritalStatus.Single;
emp.PreviousEmployers.Add("adesso");
emp.PreviousEmployers.Add("adesso Turkey");

using(var output = File.Create("emp.dat"))
{
    emp.WriteTo(output);
}

Employee empFromFile;
using (var input = File.OpenRead("emp.dat"))
{
    empFromFile = Employee.Parser.ParseFrom(input);
}

Console.WriteLine("Protobuf test is completed!");