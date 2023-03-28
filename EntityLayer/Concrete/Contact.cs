using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]  //Id değeri için key ataması gerçekleştiriliyor
        public int ContactID { get; set; }
        public string? ContactUserName { get; set; }
        public string? ContactMail { get; set; } 
        public string? ContactSubject { get; set; }= string.Empty;
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }

    }
}
