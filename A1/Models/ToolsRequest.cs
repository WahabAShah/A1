using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1.Models
{
    public class ToolsRequest
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression("^\\d{3}\\-\\d{3}\\-\\d{4}$", ErrorMessage = "Please enter phone as XXX-XXX-XXXX")]
        public string Phone { get; set; }
        public string Role { get; set; }

        public Tools Equipment { get; set; }

        [Required(ErrorMessage = "Please enter request Details")]
        public string Details { get; set; }
        public string Days { get; set; }


        
        //public bool LRented { get; set; }
        //public bool TRented { get; set; }
        //public bool PRented { get; set; }
        //public bool ORented { get; set; }


        public enum Tools
        {
            Laptop,
            Tablet,
            Phone,
            Other
        }

    }
}
