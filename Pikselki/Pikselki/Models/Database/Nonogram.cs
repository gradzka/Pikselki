// <copyright file="Nonogram.cs" company="gradzka &amp; kazimierczak-robert">
// Copyright (c) gradzka &amp; kazimierczak-robert. All rights reserved.
// </copyright>

namespace Pikselki.Models.Database
{
    using System;
    using System.Collections.Generic;

    public class Nonogram
    {
        public virtual Author Author { get; set; }

        public int AuthorID { get; set; }

        public virtual Category Category { get; set; }

        public int CategoryID { get; set; }

        public string Columns { get; set; }

        public virtual Copyright Copyright { get; set; }

        public int CopyrightID { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public string Goal { get; set; }

        public int Height { get; set; }

        public virtual License License { get; set; }

        public int LicenseID { get; set; }

        public int NonogramID { get; set; }

        public string Origin { get; set; }

        public string Rows { get; set; }

        public string Title { get; set; }

        public int Width { get; set; }
    }
}