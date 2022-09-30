namespace FirstConsoleApp
{
    class FirstConsoleApp
    {
        public static void Main(string[] args)
        {
            int[] intArr = new int[5];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i + 1;
            }
            foreach (int i in intArr)
            {
                System.Console.WriteLine(i);
            }

            char letter = 'd';
        }
    }
}