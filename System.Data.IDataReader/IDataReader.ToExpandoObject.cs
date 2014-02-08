// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;

public static partial class IDataReaderExtension
{
    /// <summary>
    ///     An IDataReader extension method that converts the @this to an expando object.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a dynamic.</returns>
    public static dynamic ToExpandoObject(this IDataReader @this)
    {
        Dictionary<int, KeyValuePair<int, string>> columnNames = Enumerable.Range(0, @this.FieldCount)
                                                                           .Select(x => new KeyValuePair<int, string>(x, @this.GetName(x)))
                                                                           .ToDictionary(pair => pair.Key);

        dynamic entity = new ExpandoObject();
        var expandoDict = (IDictionary<string, object>) entity;

        Enumerable.Range(0, @this.FieldCount)
                  .ToList()
                  .ForEach(x => expandoDict.Add(columnNames[x].Value, @this[x]));

        return entity;
    }
}