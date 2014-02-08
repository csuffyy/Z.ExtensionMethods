// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;

public static partial class IDataReaderExtension
{
    /// <summary>
    ///     An IDataReader extension method that converts the @this to a data table.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a DataTable.</returns>
    public static DataTable ToDataTable(this IDataReader @this)
    {
        var dt = new DataTable();
        dt.Load(@this);
        return dt;
    }
}