using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RelationsNaN.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [ValidateNever]
        public List<GamePurchase> GamePurchases { get; set; }
    }
}
