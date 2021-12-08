using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UniformGenerator : IRandomGenerator
    {
        Random generator;


        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        } 

        public double GetRandomNumber(double lowerBound, double upperBound)
        {
            return generator.NextDouble()*(upperBound-lowerBound)+lowerBound;
        }
    }
}
