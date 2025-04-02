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
            Service service = new Service();

            int[] input = { 3, 0, 1};
            int result = service.GetMissingNum(input);

            Console.WriteLine($"Output: {result}");
        }
    }

}
