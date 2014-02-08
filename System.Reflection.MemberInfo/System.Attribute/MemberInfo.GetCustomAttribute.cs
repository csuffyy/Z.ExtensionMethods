// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Reflection;

public static partial class MemberInfoExtension
{
    /// <summary>
    ///     Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of
    ///     the custom attribute to search for.
    /// </summary>
    /// <param name="element">
    ///     An object derived from the  class that describes a constructor, event, field, method, or
    ///     property member of a class.
    /// </param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <returns>
    ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
    ///     attribute.
    /// </returns>
    public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
    {
        return Attribute.GetCustomAttribute(element, attributeType);
    }

    /// <summary>
    ///     Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the
    ///     custom attribute to search for, and whether to search ancestors of the member.
    /// </summary>
    /// <param name="element">
    ///     An object derived from the  class that describes a constructor, event, field, method, or
    ///     property member of a class.
    /// </param>
    /// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
    /// <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
    /// <returns>
    ///     A reference to the single custom attribute of type  that is applied to , or null if there is no such
    ///     attribute.
    /// </returns>
    public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, Boolean inherit)
    {
        return Attribute.GetCustomAttribute(element, attributeType, inherit);
    }
}