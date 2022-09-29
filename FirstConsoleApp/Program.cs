namespace FirstConsoleApp
{
    class FirstConsoleApp
    {
        public static void Main(string[] args)
        {
            string name = args[0];
            string location = args[1];
            int age = int.Parse(args[2]);
            System.Console.WriteLine("Hello " + name + " from " + location + ".");
            System.Console.WriteLine("You are " + age + " years old");
        }
    }
}