using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        string filename;

        public FilePrinter(string filename)
        {
            this.filename = filename;
        }
        public void Print(IPrinter printer, Weather weather)
        {
            using (var writer = new StreamWriter(filename, true))
            {
                writer.WriteLine(weather.ToString());
            }
        }


        public void SetFilename(string fileame)
        {
            this.filename = fileame;
        }
    }
}
