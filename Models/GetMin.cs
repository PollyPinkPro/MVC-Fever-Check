using System.ComponentModel.DataAnnotations;

namespace MVCAssignment_1___2.Models
{
    public class GetMin
    {
        [Display(Name = "First Number")]
        public double Num1 { get; set; }

        [Display(Name = "Second Number")]
        public double Num2 { get; set; }

        public string Resultat { get; set; }
    }
}
