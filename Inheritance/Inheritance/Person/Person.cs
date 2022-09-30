namespace Inheritance.Person;

public class Person
{
    public Person() {}

    public Person(string firstName, string surname, string dob)
    {
        FirstName = firstName;
        Surname = surname;
        DoB = DateOnly.Parse(dob);
    }

    public string FirstName { get; set; } = "Jon";
    public string Surname { get; set; } = "Doe";
    public DateOnly DoB { get; set; } = new DateOnly(2000, 01, 01);
}