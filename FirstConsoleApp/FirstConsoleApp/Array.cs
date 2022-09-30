namespace FirstConsoleApp
{
    public class IntArray
    {
        private readonly int[] _arr;

        public IntArray(int el)
        {
            _arr = new int[el];
        }
        
        public int[] PopIntArr()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = i;
            }

            return _arr;
        }

        public void PrintIntArr()
        {
            foreach (int i in _arr)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}