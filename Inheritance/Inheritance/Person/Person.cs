namespace Inheritance.Person;

public class Person
{
    public Person() {}

    public Person(string firstName, string surname, string dob)
    {
        FirstName = firstName;
        Surname = surname;
        DoB = System.DateOnly.Parse(dob);
    }

    public string FirstName { get; set; } = "Jon";
    public string Surname { get; set; } = "Doe";
    public System.DateOnly DoB { get; set; } = System.DateOnly.Parse("1970-01-01");

    public override string ToString()
    {
        return $"FirstName: {FirstName}, Surname: {Surname}, Date of Birth: {DoB}";
    }
}