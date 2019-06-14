// <copyright file="Game.cs" company="gradzka &amp; kazimierczak-robert">
// Copyright (c) gradzka &amp; kazimierczak-robert. All rights reserved.
// </copyright>

namespace Pikselki.Models.Database
{
    using System;

    public class Game
    {
        public int GameID { get; set; }

        public bool IsCompleted { get; set; }

        public virtual Nonogram Nonogram { get; set; }

        public int NonogramID { get; set; }

        public virtual Player Player { get; set; }

        public int PlayerID { get; set; }

        public string State { get; set; }

        public TimeSpan Time { get; set; }
    }
}