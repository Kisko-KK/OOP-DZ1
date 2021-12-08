using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IRandomGenerator
    {
        double GetRandomNumber(double lowerBound, double upperBound);
    }
}
