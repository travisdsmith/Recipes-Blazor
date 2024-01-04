using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; } = null!;
    }
}
