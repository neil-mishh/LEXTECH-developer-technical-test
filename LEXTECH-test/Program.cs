namespace LEXTECH_test
{
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
