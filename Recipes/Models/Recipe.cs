﻿using System;
using System.Collections.Generic;

namespace Recipes.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int CategoryId { get; set; }
        public bool Trash { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Note> Notes { get; set; }
    }
}
