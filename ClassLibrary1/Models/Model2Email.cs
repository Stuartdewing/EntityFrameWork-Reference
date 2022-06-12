using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Model2Email
    {
        public int Id { get; set; }                 // Property

        [Required]                                  // Not Nullable
        [MaxLength(200)]                            // Change from NVARMAX
        public string EmailAddress { get; set; }    // Property
    }
}
