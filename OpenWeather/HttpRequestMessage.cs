using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class HttpRequestMessage
    {
        public class city
        {
            public string city{ get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }
        public class wind
        {
            public double speed { get;set }
        }

        public class sys
        {
            public long sunrise {get; set; }
            public long sunset {get; set; }
        }

        public class Root
        {
            public coord coord { get; set; }
            public List <weather> weather { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
            public string @base { get; set; }
            public Main main { get; set; }
            public int visibility { get; set; }
            public int dt { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
        }
    }

    internal class coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
}