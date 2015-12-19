﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astro
{
    /// <summary>
    /// Sideral time value
    /// </summary>
    public struct SideralTime
    {
        /// <summary>
        /// Create a new sideral time
        /// </summary>
        public SideralTime(Double time)
            : this()
        {
            this.Value = time;
        }

        /// <summary>
        /// Convert to string
        /// </summary>
        //public override string ToString()
        //{
        //    return SweFormat.FormatAsTime(Value);
        //}

        /// <summary>
        /// Conversion en double
        /// </summary>
        public static implicit operator double(SideralTime sid)
        {
            return sid.Value;
        }

        /// <summary>
        /// Conversion depuis un double
        /// </summary>
        public static implicit operator SideralTime(double val)
        {
            return new SideralTime(val);
        }

        /// <summary>
        /// Value of the sideral time
        /// </summary>
        public Double Value { get; private set; }
    }
}
