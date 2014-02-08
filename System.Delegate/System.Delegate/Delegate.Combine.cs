// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;

public static partial class DelegateExtension
{
    /// <summary>
    ///     Concatenates the invocation lists of two delegates.
    /// </summary>
    /// <param name="a">The delegate whose invocation list comes first.</param>
    /// <param name="b">The delegate whose invocation list comes last.</param>
    /// ###
    /// <returns>
    ///     A new delegate with an invocation list that concatenates the invocation lists of  and  in that order. Returns
    ///     if  is null, returns  if  is a null reference, and returns a null reference if both  and  are null references.
    /// </returns>
    public static Delegate Combine(this Delegate a, Delegate b)
    {
        return Delegate.Combine(a, b);
    }
}