// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;
using System.Data.SqlClient;

public static partial class SqlCommandExtension
{
    /// <summary>
    ///     Executes the query, and returns the result set as DataSet.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A DataSet that is equivalent to the result set.</returns>
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
    ///               public class System_Data_SqlClient_SqlCommand_ExecuteDataSet
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteDataSet()
    ///                   {
    ///                       DataSet result;
    ///                       const string sql = @&quot;
    ///           SELECT 1
    ///           SELECT 2
    ///           SELECT 3
    ///           &quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               result = @this.ExecuteDataSet(); // return DataSet (3 tables).
    ///                           }
    ///                       }
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(3, result.Tables.Count);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static DataSet ExecuteDataSet(this SqlCommand @this)
    {
        var ds = new DataSet();
        using (var sqlDataAdapter = new SqlDataAdapter(@this))
        {
            sqlDataAdapter.Fill(ds);
        }

        return ds;
    }
}