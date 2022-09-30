// See https://aka.ms/new-console-template for more information

Inheritance.Person.Person person = new();
System.Console.WriteLine(person.ToString());

System.Console.WriteLine("Enter first name: ");
string? firstName = System.Console.ReadLine();
System.Console.WriteLine("Enter last name: ");
string? lastName = System.Console.ReadLine();
System.Console.WriteLine("Enter dob format yyyy-mm-dd: ");
string? dob = System.Console.ReadLine();

person.FirstName = firstName;
person.Surname = lastName;
person.DoB = System.DateOnly.Parse(dob);

System.Console.WriteLine($"Hello, {person.FirstName} {person.Surname}! ");
System.Console.WriteLine($"You were born {person.DoB}");