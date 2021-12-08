using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BiasedGenerator : IRandomGenerator
    {
        Random generator;

        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double GetRandomNumber(double lowerBound, double upperBound)
        {
            double prob = (double)2 / 3;
            if (generator.NextDouble() <= prob)
                return generator.NextDouble() * (upperBound / 2 - lowerBound) + lowerBound;
            else
                return generator.NextDouble() * (upperBound - (upperBound / 2) + (upperBound / 2));
                
        }
    }
}
