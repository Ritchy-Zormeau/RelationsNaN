using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RelationsNaN.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int ReleaseYear { get; set; }

        public int? GenreId { get; set; }
        [ValidateNever]
        public Genre? Genre { get; set; }
    }
}
