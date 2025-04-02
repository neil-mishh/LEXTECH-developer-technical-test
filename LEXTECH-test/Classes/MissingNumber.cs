using LEXTECH_test.Interfaces;

namespace LEXTECH_test.Classes
{
    public class MissingNumber : IMissingNumber
    {
        public int GetExpectedSum(int n)
        {
            return n * (n + 1) / 2;
        }
        public int GetCurrentSum(int[] input)
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
            int expectedSum = GetExpectedSum(input.Length);
            int currentSum = GetCurrentSum(input);

            return expectedSum - currentSum;
        }
    }
}
