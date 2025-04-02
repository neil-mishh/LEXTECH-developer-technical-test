using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEXTECH_test.Interfaces
{
    public interface IMissingNumber
    {
        int GetExpectedSum(int n);
        int GetCurrentSum(int[] input);
        int GetMissingNum(int[] input);
    }
}
