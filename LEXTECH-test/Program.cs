namespace Program
{
    public class Service
    {
        public int GetMissingNum(int[] input)
        {
            int n = input.Length;
            int sum = n * (n + 1) / 2;
            int total = 0;
            for(int i = 0; i < n; i++)
            {
                total += input[i];
            }
            return sum - total;
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
