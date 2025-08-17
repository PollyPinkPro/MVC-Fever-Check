using System.ComponentModel.DataAnnotations;

namespace MVCAssignment_1___2.Models
{
    public class Fever
    {
        [Required] // Data annotation
        [Display(Name ="Body Temperature")]// Changing text displayed other the form field

        public double BTemp { get; set; }
        public string Resultat { get; set; }
        public string Unit { get; set; } // "Celsius" or "Fahrenheit"

    }
}
