// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Data;
using System.Data.Common;

public static partial class DbCommandExtension
{
    /// <summary>
    ///     A DbCommand extension method that executes the entity operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
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
    ///               public class System_Data_Common_DbCommand_ExecuteEntity
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteEntity()
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
    ///                               var entity = command.ExecuteEntity&lt;TestObject&gt;();
    ///           
    ///                               // Unit Test
    ///                               Assert.AreEqual(1, entity.IntColumn);
    ///                               Assert.AreEqual(&quot;FizzBuzz&quot;, entity.StringColumn);
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
    public static T ExecuteEntity<T>(this DbCommand @this) where T : new()
    {
        using (IDataReader reader = @this.ExecuteReader())
        {
            reader.Read();
            return reader.ToEntity<T>();
        }
    }
}