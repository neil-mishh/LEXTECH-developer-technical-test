namespace Program
{
    public class Service
    {
        public int GetExpectedSum(int n)
        {
            return n * (n + 1) / 2;
        }
        public int GetCurrentSum(int[]input)
        {
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                total += input[i];
            }
            return total;
        }
        public int GetMissingNum(int[] input)
        {
            int n = input.Length;
            int expectedSum = GetExpectedSum(n);
            int currentSum = GetCurrentSum(input);

            return expectedSum - currentSum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Service service = new Service();

                Console.WriteLine("Enter number input separated by commas: ");
                int[] input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
                int result = service.GetMissingNum(input);

                Console.WriteLine($"Output: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
