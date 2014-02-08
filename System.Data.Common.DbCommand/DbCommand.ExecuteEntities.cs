// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Data.Common;

public static partial class DbCommandExtension
{
    /// <summary>
    ///     Enumerates execute entities in this collection.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
    /// <example>
    ///     <code>
    ///           using System.Collections.Generic;
    ///           using System.Data.Common;
    ///           using System.Data.SqlClient;
    ///           using System.Linq;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Data_Common_DbCommand_ExecuteEntities
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteEntities()
    ///                   {
    ///                       string sql = &quot;SELECT 1 AS IntColumn, &apos;FizzBuzz&apos; AS StringColumn UNION SELECT 2, &apos;BuzzBuzz&apos;&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           conn.Open();
    ///                           using (DbCommand command = conn.CreateCommand())
    ///                           {
    ///                               command.CommandText = sql;
    ///                               List&lt;TestObject&gt; list = command.ExecuteEntities&lt;TestObject&gt;().ToList();
    ///           
    ///                               // Unit Test
    ///                               Assert.AreEqual(1, list[0].IntColumn);
    ///                               Assert.AreEqual(&quot;FizzBuzz&quot;, list[0].StringColumn);
    ///                               Assert.AreEqual(2, list[1].IntColumn);
    ///                               Assert.AreEqual(&quot;BuzzBuzz&quot;, list[1].StringColumn);
    ///                           }
    ///                       }
    ///                   }
    ///           
    ///                   public class TestObject
    ///                   {
    ///                       public int IntColumn;
    ///                       public string StringColumn { get; set; }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static IEnumerable<T> ExecuteEntities<T>(this DbCommand @this) where T : new()
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            return reader.ToEntities<T>();
        }
    }
}