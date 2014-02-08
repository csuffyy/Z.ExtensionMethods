// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Text.RegularExpressions;

public static partial class StringExtension
{
    /// <summary>
    ///     Searches the specified input string for all occurrences of a specified regular expression.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <returns>
    ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
    ///     collection object.
    /// </returns>
    public static MatchCollection Matches(this String input, String pattern)
    {
        return Regex.Matches(input, pattern);
    }

    /// <summary>
    ///     Searches the specified input string for all occurrences of a specified regular expression, using the
    ///     specified matching options.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="pattern">The regular expression pattern to match.</param>
    /// <param name="options">A bitwise combination of the enumeration values that specify options for matching.</param>
    /// <returns>
    ///     A collection of the  objects found by the search. If no matches are found, the method returns an empty
    ///     collection object.
    /// </returns>
    public static MatchCollection Matches(this String input, String pattern, RegexOptions options)
    {
        return Regex.Matches(input, pattern, options);
    }
}