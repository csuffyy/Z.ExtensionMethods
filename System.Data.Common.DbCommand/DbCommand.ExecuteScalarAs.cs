// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data.Common;

public static partial class DbCommandExtension
{
    /// <summary>
    ///     A DbCommand extension method that executes the scalar as operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using System.Data.SqlClient;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Data_Common_DbCommand_ExecuteScalarAs
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteScalarAs()
    ///                   {
    ///                       const string sql = @&quot;SELECT 1 As IntColumn&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               var result = @this.ExecuteScalarAs&lt;int&gt;();
    ///           
    ///                               // UnitTest
    ///                               Assert.AreEqual(1, result);
    ///                           }
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T ExecuteScalarAs<T>(this DbCommand @this)
    {
        return (T) @this.ExecuteScalar();
    }
}