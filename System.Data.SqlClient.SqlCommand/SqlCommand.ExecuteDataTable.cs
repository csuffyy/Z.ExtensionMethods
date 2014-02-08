// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;
using System.Data.SqlClient;

public static partial class SqlCommandExtension
{
    /// <summary>
    ///     Executes the query, and returns the first result set as DataTable.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DataTable that is equivalent to the first result set.</returns>
    /// <example>
    ///     <code>
    ///           using System.Data;
    ///           using System.Data.SqlClient;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Data_SqlClient_SqlCommand_ExecuteDataTable
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteDataTable()
    ///                   {
    ///                       DataTable result;
    ///                       const string sql = @&quot;
    ///           SELECT  1 AS A
    ///           UNION
    ///           SELECT  2
    ///           UNION
    ///           SELECT  3
    ///           &quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               result = @this.ExecuteDataTable(); // return DataTable (3 rows).
    ///                           }
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(3, result.Rows.Count);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static DataTable ExecuteDataTable(this SqlCommand @this)
    {
        var ds = new DataSet();
        using (var sqlDataAdapter = new SqlDataAdapter(@this))
        {
            sqlDataAdapter.Fill(ds);
        }

        return ds.Tables[0];
    }
}