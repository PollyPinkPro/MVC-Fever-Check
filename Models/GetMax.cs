using System.ComponentModel.DataAnnotations;

namespace MVCAssignment_1___2.Models
{
    public class GetMax
    {
        [Display(Name = "First number")]
        public double Num1 { get; set; }

        [Display(Name = "Second number")]
        public double Num2 { get; set; }
        public string Message { get; set; }




    }
}
