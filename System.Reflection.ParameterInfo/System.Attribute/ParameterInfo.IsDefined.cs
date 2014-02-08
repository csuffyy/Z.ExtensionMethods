// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

public static partial class ParameterInfoExtension
{
    /// <summary>
    ///     Determines whether any custom attributes are applied to a method parameter. Parameters specify the method
    ///     parameter, and the type of the custom attribute to search for.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
    public static Boolean IsDefined(this ParameterInfo element, Type attributeType)
    {
        return Attribute.IsDefined(element, attributeType);
    }

    /// <summary>
    ///     Determines whether any custom attributes are applied to a method parameter. Parameters specify the method
    ///     parameter, the type of the custom attribute to search for, and whether to search ancestors of the method
    ///     parameter.
    /// </summary>
    /// <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
    /// <returns>true if a custom attribute of type  is applied to ; otherwise, false.</returns>
    public static Boolean IsDefined(this ParameterInfo element, Type attributeType, Boolean inherit)
    {
        return Attribute.IsDefined(element, attributeType, inherit);
    }
}