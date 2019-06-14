// <copyright file="Player.cs" company="gradzka &amp; kazimierczak-robert">
// Copyright (c) gradzka &amp; kazimierczak-robert. All rights reserved.
// </copyright>

namespace Pikselki.Models.Database
{
    using System.Collections.Generic;

    public class Player
    {
        public virtual ICollection<Game> Games { get; set; }

        public string Name { get; set; }

        public int PlayerID { get; set; }
    }
}