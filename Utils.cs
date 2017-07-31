﻿namespace FF12RNGHelper
{
    /// <summary>
    /// Class for holding methods used throughout
    /// the life of the program
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Convert a random number into its
        /// percentage. Used for ptests
        /// </summary>
        public static int RandToPercent(uint prng)
        {
            return (int) (prng % 100);
        }
    }
}