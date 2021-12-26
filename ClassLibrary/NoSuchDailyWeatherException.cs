using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class NoSuchDailyWeatherException : Exception
    {
        private DateTime date;

        public NoSuchDailyWeatherException() { }
        public NoSuchDailyWeatherException(DateTime date,string message) :base(message) { this.date = date;}
        public NoSuchDailyWeatherException(string message) : base(message) { }
        public NoSuchDailyWeatherException(string message, Exception innerException) : base(message, innerException) { }
        protected NoSuchDailyWeatherException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
