// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Lead Pipe Software. All rights reserved.
// Licensed under the MIT License. Please see the LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;

namespace LeadPipe.Net.Extensions
{
    /// <summary>
    /// A set of Int32 extension methods.
    /// </summary>
    public static class IntExtensions
    {
        private const long Exabyte = Petabyte * 1024;
        private const long Gigabyte = Megabyte * 1024;
        private const long Kilobyte = 1024;
        private const long Megabyte = Kilobyte * 1024;
        private const long Petabyte = Terabyte * 1024;
        private const long Terabyte = Gigabyte * 1024;

        public static long Bytes(this int number)
        {
            return number;
        }

        /// <summary>
        /// Returns a TimeSpan that represents the integer in days.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A TimeSpan of the integer in days.</returns>
        public static TimeSpan Days(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return TimeSpan.FromDays(value);
        }

        public static long Exabytes(this int number)
        {
            return number * Exabyte;
        }

        /// <summary>
        /// Gets the digit count.
        /// </summary>
        /// <param name="integerToCount">The integer to count.</param>
        /// <param name="countSignAsDigit">if set to <c>true</c> [count sign as digit].</param>
        /// <returns>
        /// The number of digits in the integer.
        /// </returns>
        public static int GetDigitCount(this int integerToCount, bool countSignAsDigit = false)
        {
            //// Sure, we could do an Int.ToString().Length however, that would allocate heap space. This is faster.

            double value = integerToCount;

            var sign = 0;

            if (countSignAsDigit)
            {
                if (value < 0)
                {
                    value = -value;
                    sign = 1;
                }
            }

            if (value <= 9)
            {
                return sign + 1;
            }

            if (value <= 99)
            {
                return sign + 2;
            }

            if (value <= 999)
            {
                return sign + 3;
            }

            if (value <= 9999)
            {
                return sign + 4;
            }

            if (value <= 99999)
            {
                return sign + 5;
            }

            if (value <= 999999)
            {
                return sign + 6;
            }

            if (value <= 9999999)
            {
                return sign + 7;
            }

            if (value <= 99999999)
            {
                return sign + 8;
            }

            if (value <= 999999999)
            {
                return sign + 9;
            }

            return sign + 10;
        }

        /// <summary>
        /// Gets the factorial of an integer.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The factorial.</returns>
        public static int GetFactorial(this int value)
        {
            Func<int, int> factorial = n => n == 0 ? 1 : Enumerable.Range(1, n).Aggregate((acc, x) => acc * x);

            return factorial(value);
        }

        public static long Gigabytes(this int number)
        {
            return number * Gigabyte;
        }

        /// <summary>
        /// Returns a TimeSpan that represents the integer in hours.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A TimeSpan of the integer in hours.</returns>
        public static TimeSpan Hours(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return TimeSpan.FromHours(value);
        }

        /// <summary>
        /// Determines whether the integer is in a range.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="lower">The lower value.</param>
        /// <param name="upper">The upper value.</param>
        /// <returns>
        ///   <c>true</c> if the specified lower is in the range; otherwise, <c>false</c>.
        /// </returns>
        public static bool InRange(this int value, int lower, int upper)
        {
            // Return whether the value is in the range...
            return value >= lower && value <= upper;
        }

        /// <summary>
        /// Determines whether the integer is between two numbers.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="lower">The lower value.</param>
        /// <param name="upper">The upper value.</param>
        /// <returns>
        ///   <c>true</c> if the specified lower is between the lower and upper values; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBetween(this int value, int lower, int upper)
        {
            // Return whether the value is between the lower and upper values...
            return value > lower && value < upper;
        }

        /// <summary>
        /// Determines whether the specified value is an even number.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is even; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEven(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return (value % 2) == 0;
        }

        /// <summary>
        /// Determines whether the specified integer is an odd number.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is odd; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsOdd(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return (value % 2) != 0;
        }

        public static long Kilobytes(this int number)
        {
            return number * Kilobyte;
        }

        public static long Megabytes(this int number)
        {
            return number * Megabyte;
        }

        /// <summary>
        /// Returns a TimeSpan that represents the integer in milliseconds.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A TimeSpan of the integer in milliseconds.</returns>
        public static TimeSpan Milliseconds(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return TimeSpan.FromMilliseconds(value);
        }

        /// <summary>
        /// Returns a TimeSpan that represents the integer in minutes.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A TimeSpan of the integer in minutes.</returns>
        public static TimeSpan Minutes(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return TimeSpan.FromMinutes(value);
        }

        public static long Petabytes(this int number)
        {
            return number * Petabyte;
        }

        /// <summary>
        /// Returns a TimeSpan that represents the integer in seconds.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A TimeSpan of the integer in seconds.</returns>
        public static TimeSpan Seconds(this int value)
        {
            //// TODO: [GBM] Write unit tests.

            return TimeSpan.FromSeconds(value);
        }

        public static long Terabytes(this int number)
        {
            return number * Terabyte;
        }

        /// <summary>
        /// Performs the specified action for the specified number of times.
        /// </summary>
        /// /// <code>
        /// 5.Times(() => { DoSomething(); });
        /// </code>
        /// <param name="value">The value.</param>
        /// <param name="action">The action.</param>
        public static void Times(this int value, Action action)
        {
            if (action == null) return;

            for (var i = 0; i < value; i++)
            {
                action();
            }
        }

        /// <summary>
        /// Performs the specified action for the specified number of times passing in the iterator each time.
        /// </summary>
        /// /// <code>
        /// 5.Times((x) => { DoSomething(x); });
        /// </code>
        /// <param name="value">The value.</param>
        /// <param name="action">The action.</param>
        public static void Times(this int value, Action<int> action)
        {
            if (action == null) return;

            for (var c = 0; c < value; c++)
            {
                action(c);
            }
        }

        /// <summary>
        /// Performs the specified action and passes in the iterator once for each value in the range starting at the integer's value and ending at the specified value.
        /// </summary>
        /// <code>
        /// 5.UpTo(10, (x) => { DoSomething(x); });
        /// </code>
        /// <param name="value">The value.</param>
        /// <param name="stopAt">The value to stop at.</param>
        /// <param name="action">The action to perform.</param>
        public static void UpTo(this int value, int stopAt, Action<int> action)
        {
            //// TODO: [GBM] Write unit tests.

            for (var a = value; a <= stopAt; a++)
            {
                action(a);
            }
        }
    }
}