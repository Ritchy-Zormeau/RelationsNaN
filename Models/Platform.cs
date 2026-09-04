using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RelationsNaN.Models
{
    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [ValidateNever]
        public List<Game> Games { get; set; } = new List<Game>();

    }
}
