using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyIStrukturyDanych
{
    class HeapAlgorithmMeasurement 
    {
        public double n { get; set; }
        public double t { get; set; }
        public double O { get; set; }
        public double Tn { get; set; }
        public double OT { get; set; }

        public HeapAlgorithmMeasurement(int arrayElements, double time)
        {
            n = arrayElements;
            t = time;
            O = n * Math.Log(n);
            Tn = SortAlgorithms.Tn;
            OT = O / Tn;
        }
    }
}
