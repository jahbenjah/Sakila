﻿using System;
using System.Collections.Generic;

namespace Sakila.Core.Entities
{
    public partial class Category
    {
        public Category()
        {
            FilmCategory = new HashSet<FilmCategory>();
        }

        public byte CategoryId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public virtual ICollection<FilmCategory> FilmCategory { get; set; }
    }
}
