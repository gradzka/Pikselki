// <copyright file="Category.cs" company="gradzka &amp; kazimierczak-robert">
// Copyright (c) gradzka &amp; kazimierczak-robert. All rights reserved.
// </copyright>

namespace Pikselki.Models.Database
{
    using System.Collections.Generic;

    public class Category
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Nonogram> Nonograms { get; set; }
    }
}