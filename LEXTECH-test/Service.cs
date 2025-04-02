using LEXTECH_test.Interfaces;

namespace LEXTECH_test
{
    public class Service
    {
        private IMissingNumber _missingNumber;
        public Service(IMissingNumber missingNumber)
        {
            _missingNumber = missingNumber;
        }
        public int GetMissingNum(int[] input)
        {
            return _missingNumber.GetMissingNum(input);
        }
    }
}
