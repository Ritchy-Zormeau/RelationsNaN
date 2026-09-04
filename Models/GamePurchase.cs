using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RelationsNaN.Models
{
    public class GamePurchase
    {
        public int Id { get; set; }
        [ValidateNever]
        public Game Game { get; set; }
        [ValidateNever]
        public Purchase Purchase { get; set; }

        public int Count { get; set; }
    }
}
