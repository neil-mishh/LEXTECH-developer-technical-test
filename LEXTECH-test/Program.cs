namespace Program
{
    public class Service
    {
        public int GetMissingNum(int[] input)
        {
            return input.Length;
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
