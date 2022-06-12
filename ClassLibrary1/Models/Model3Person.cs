using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Model3Person
    {
        public int Id { get; set; }                 // Property

        [Required]                                  // Not Nullable
        [MaxLength(50)]                             // Change from NVARMAX
        public string FirstName { get; set; }       // Property

        [Required]                                  // Not Nullable
        [MaxLength(50)]                             // Change from NVARMAX
        public string LastName { get; set; }        // Property
        public int Age { get; set; }                // Property
        public List<Model1Address> Addresses { get; set; } = new List<Model1Address>();     // Property
        public List<Model2Email> EmailAddresses { get; set; } = new List<Model2Email>();    // Property

    }
}
