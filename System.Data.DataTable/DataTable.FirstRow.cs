// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;

public static class DataTableExtension
{
    /// <summary>
    ///     A DataTable extension method that return the first row.
    /// </summary>
    /// <param name="table">The table to act on.</param>
    /// <returns>The first row of the table.</returns>
    public static DataRow FirstRow(this DataTable table)
    {
        return table.Rows[0];
    }
}