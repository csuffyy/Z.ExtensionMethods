// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;
using System.Data.Common;

public static partial class DbCommandExtension
{
    /// <summary>
    ///     A DbCommand extension method that executes the expando object operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>.</returns>
    /// <example>
    ///     <code>
    ///           using System.Data.Common;
    ///           using System.Data.SqlClient;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Data_Common_DbCommand_ExecuteExpandoObject
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteExpandoObject()
    ///                   {
    ///                       string sql = &quot;SELECT 1 AS IntColumn, &apos;FizzBuzz&apos; AS StringColumn&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           conn.Open();
    ///                           using (DbCommand command = conn.CreateCommand())
    ///                           {
    ///                               command.CommandText = sql;
    ///                               dynamic entity = command.ExecuteExpandoObject();
    ///           
    ///                               // Unit Test
    ///                               Assert.AreEqual(1, entity.IntColumn);
    ///                               Assert.AreEqual(&quot;FizzBuzz&quot;, entity.StringColumn);
    ///                           }
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static dynamic ExecuteExpandoObject(this DbCommand @this)
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            reader.Read();
            return reader.ToExpandoObject();
        }
    }
}