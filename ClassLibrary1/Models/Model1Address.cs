using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Model1Address
    {
        public int Id { get; set; }                 // Property

        [Required]                                  // Not Nullable
        [MaxLength(200)]                            // Change from NVARMAX
        public string StreetAdress { get; set; }    // Property

        [Required]                                  // Not Nullable
        [MaxLength(200)]                            // Change from NVARMAX
        public string City { get; set; }            // Property

        [Required]                                  // Not Nullable
        [MaxLength(200)]                            // Change from NVARMAX
        [Column(TypeName = "varchar(10)")]          //None Unicode Values
        public string ZipCode { get; set; }         // Property
    }
}
