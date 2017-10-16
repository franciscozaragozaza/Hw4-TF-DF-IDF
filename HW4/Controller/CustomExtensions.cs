using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4.Controller
{
    public static class CustomExtensions
    {
        /// <summary>
        /// Turns a String into an array splitted by " ".
        /// </summary>
        /// <param name="value">
        /// Text string to split.</param>
        /// <param name="sort">
        /// Sorts the array terms if is set to true. Default is set to false.</param>
        /// <param name="lower">
        /// Returns the array in lowercase if set to true. Default valuew is false</param>
        /// <returns>Returns an array of n size, where n is the number of distinct termns
        /// in the String.</returns>
        public static string[] splitToArray(this string value, bool sort = false, bool lower = false)
        {
            String[] splittedString;

            if (lower)
            {
                value.ToLower();
            }//ends if
            splittedString = value.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);//splits String into array.
            if (sort)
            {
                Array.Sort(splittedString, StringComparer.InvariantCulture);
            }//ends if

            return splittedString;
        }

        /// <summary>
        /// Strips the String from the following punctuation 
        /// signs:
        /// ".", ",", ":", ";", "\", "(" and ")".
        /// </summary>
        /// <param name="value">
        /// A String object that contains
        /// punctuations sings.
        /// </param>
        public static string stripPunctuations(this string value)
        {
            value = value.Replace(". ", " ");
            value = value.Replace(", ", " ");
            value = value.Replace(": ", " ");
            value = value.Replace("; ", " ");
            value = value.Replace("\" ", " ");
            value = value.Replace("(", string.Empty);
            value = value.Replace(")", string.Empty);

            return value;
        }
    }
}