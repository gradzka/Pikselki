// <copyright file="Copyright.cs" company="gradzka &amp; kazimierczak-robert">
// Copyright (c) gradzka &amp; kazimierczak-robert. All rights reserved.
// </copyright>

namespace Pikselki.Models.Database
{
    using System.Collections.Generic;

    public class Copyright
    {
        public int CopyrightID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Nonogram> Nonograms { get; set; }
    }
}