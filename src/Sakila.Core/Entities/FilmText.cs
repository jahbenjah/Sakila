﻿using System;
using System.Collections.Generic;

namespace Sakila.Core.Entities
{
    public partial class FilmText
    {
        public short FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
