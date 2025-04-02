namespace LEXTECH_test.Interfaces
{
    public interface IMissingNumber
    {
        int GetExpectedSum(int n);
        int GetCurrentSum(int[] input);
        int GetMissingNum(int[] input);
    }
}
