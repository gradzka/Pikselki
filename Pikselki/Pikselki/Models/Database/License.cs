// <copyright file="License.cs" company="gradzka &amp; kazimierczak-robert">
// Copyright (c) gradzka &amp; kazimierczak-robert. All rights reserved.
// </copyright>

namespace Pikselki.Models.Database
{
    using System.Collections.Generic;

    public class License
    {
        public int LicenseID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Nonogram> Nonograms { get; set; }
    }
}