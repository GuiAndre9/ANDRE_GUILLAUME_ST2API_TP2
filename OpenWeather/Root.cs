using System.Collections.Generic;
namespace ClassLibrary1
{
    public class Root
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public List<Main> data { get; set; }
    }
}
