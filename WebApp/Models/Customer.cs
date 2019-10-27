using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter Valid Name") ]
        [MaxLength(30,ErrorMessage ="Name Maximum Length 30")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Email Maximum Length 30")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9]+\.[a-zA-Z0-9-.]+$",ErrorMessage ="Please Enter Valid Email")]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Range(typeof(DateTime),"01/Jan/2019","30/Jun/2019",ErrorMessage = "Value For {0} Must Be Between {1} And {2}")]
        public DateTime DateRegistered { get; set; }

        [Required]
        public Boolean Day1 { get; set; }

        [Required]
        public Boolean Day2 { get; set; }

        [Required]
        public Boolean Day3 { get; set; }

        [Required]
        [MaxLength(100,ErrorMessage ="Additional Request Maximum Length 100")]
        public string AdditionalRequest { get; set; }
    }
}
