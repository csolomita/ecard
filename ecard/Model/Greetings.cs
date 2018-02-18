using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecard.Model
{
    public class Greetings
    {
        public int? ID { get; set; }
        public string friendname { get; set; }
        public string friendemail { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string sendername { get; set; }
        public string senderemail { get; set; }
    }
}
