namespace Student;

public class Student
{
    public Student() {}
    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public string FirstName { get; set; } = "Jon";
    public string LastName { get; set; } = "Doe";
    public int Age { get; set; } = 10;

    public override string ToString()
    {
        return $"firstName: {FirstName}, lastName: {LastName}, Age: {Age}";
    }
}