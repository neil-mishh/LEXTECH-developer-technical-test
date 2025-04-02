using LEXTECH_test.Classes;
using LEXTECH_test.Interfaces;

namespace LEXTECH_test
{
    public class Service
    {
        private IMissingNumber _missingNumber;
        public Service()
        {
            _missingNumber = new MissingNumber();
        }
        public int GetMissingNum(int[] input)
        {
            return _missingNumber.GetMissingNum(input);
        }
    }
}
