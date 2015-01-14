using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Mvc4DDD.MVC.EndUserApp.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Add Hyphen if String is empty.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String AddHyphenIfEmpty(this String s)
        {
            if (String.IsNullOrWhiteSpace(s)) return "-";
            return s;
        }

        /// <summary>
        /// Build an URI.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String GetUri(this string s)
        {
            if (String.IsNullOrWhiteSpace(s)) return "";

            return new UriBuilder(s).Uri.ToString();
        }


        /// <summary>
        /// Format a string to be SEO friendly.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SeoString(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            text = text.Normalize(NormalizationForm.FormD);
            var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();

            text = new string(chars).Normalize(NormalizationForm.FormC);

            text = text.Trim();
            // remove entities
            text = Regex.Replace(text, @"&\w+;", "");
            // remove anything that is not letters, numbers, dash, or space
            text = Regex.Replace(text, @"[^A-Za-z0-9\-\s]", "");
            // replace spaces
            text = text.Replace(' ', '-');
            // if we end up with multiple dashes, collapse to single dash            
            text = Regex.Replace(text, @"\-{2,}", "-");

            text = text.ToLower();
            // if it's too long, clip it
            if (text.Length > 80)
                text = text.Substring(0, 79);
            // remove trailing dashes
            text = text.TrimEnd(new[] { '-' });

            return text;
        }
    }
}