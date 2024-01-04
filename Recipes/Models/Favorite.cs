using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public partial class Favorite
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int RecipeId { get; set; }
    }
}
