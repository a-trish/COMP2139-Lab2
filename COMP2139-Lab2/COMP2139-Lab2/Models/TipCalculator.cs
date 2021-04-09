using System.ComponentModel.DataAnnotations;

namespace COMP2139_Lab2.Models
{
    //TESTING testing
    public class TipCalculator
    {
        [Required(ErrorMessage="Please enter a value for the cost of the meal.")]
        [Range(0.0, 10000.0, ErrorMessage = "Please enter a value grater than zero")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {
            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else
            {
                return 0;
            }
        }
    }
}
