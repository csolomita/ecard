using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Greetings
    {
        [Key]
        public int? ID { get; set; }

        [DisplayName("Your Friend's Name")]
        public string friendname { get; set; }

        [DisplayName("Your Friend's Email")]
        public string friendemail { get; set; }

        [DisplayName("Email Subject")]
        public string subject { get; set; }

        [DisplayName("Your Custom Message")]
        public string message { get; set; }

        [DisplayName("Your Name")]
        public string sendername { get; set; }

        [DisplayName("Your Email")]
        public string senderemail { get; set; }
    }
}
