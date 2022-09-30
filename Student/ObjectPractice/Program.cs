namespace Student
{
    internal static class Runner
    {
        public static void Main(string[] args)
        {
            Student jon = new();
            Student ace = new Student("Ace", "Kokuren", System.Int32.MaxValue);
            System.Console.WriteLine(jon);
            jon.FirstName = "Steve";
            System.Console.WriteLine(jon);
            System.Console.WriteLine(ace);
            ace.Age++;
            System.Console.WriteLine(ace.Age);
            System.Console.ReadLine();
        }
    }
}