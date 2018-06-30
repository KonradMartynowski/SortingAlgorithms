using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyIStrukturyDanych
{
    class GetArrayParameters 
    {
        public static int GetArrayLenght(string cmbChoice)
        {
            if (cmbChoice == "100") return 100;
            if (cmbChoice == "1000") return 1000;
            if (cmbChoice == "10000") return 10000;
            if (cmbChoice == "20000") return 20000;
            if (cmbChoice == "30000") return 30000;
            if (cmbChoice == "2^8") return (int)Math.Pow(2, 8);
            if (cmbChoice == "2^9") return (int)Math.Pow(2, 9);
            if (cmbChoice == "2^10") return (int)Math.Pow(2, 10);
            if (cmbChoice == "2^11") return (int)Math.Pow(2, 11);
            if (cmbChoice == "2^12") return (int)Math.Pow(2, 12);
            if (cmbChoice == "2^13") return (int)Math.Pow(2, 13);
            if (cmbChoice == "2^14") return (int)Math.Pow(2, 14);
            if (cmbChoice == "2^15") return (int)Math.Pow(2, 15);
            if (cmbChoice == "2^16") return (int)Math.Pow(2, 16);
            else return 0;
        }

        public static int GetMaxRange(string cmbRangeChoice)
        {
            if (cmbRangeChoice == "-100 - 100") return 101;
            if (cmbRangeChoice == "-1000 - 1000") return 1001;
            if (cmbRangeChoice == "-2000 - 2000") return 2001;
            if (cmbRangeChoice == "-3000 - 3000") return 3001;
            else return 1;
        }

        public static int GetMinRange(string cmbRangeChoice)
        {
            if (cmbRangeChoice == "-100 - 100") return -100;
            if (cmbRangeChoice == "-1000 - 1000") return -1000;
            if (cmbRangeChoice == "-2000 - 2000") return -2000;
            if (cmbRangeChoice == "-3000 - 3000") return -3000;
            else return -1;
        }
    }
}
