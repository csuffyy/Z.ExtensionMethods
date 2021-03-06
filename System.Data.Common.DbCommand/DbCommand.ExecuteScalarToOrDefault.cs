// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System;
using System.Data.Common;

public static partial class DbCommandExtension
{
    /// <summary>
    ///     A DbCommand extension method that executes the scalar to or default operation.
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
    ///               public class System_Data_Common_DbCommand_ExecuteScalarToOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteScalarToOrDefault()
    ///                   {
    ///                       const string sql = @&quot;SELECT &apos;FizzBuzz&apos; As StringColumn&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               var result1 = @this.ExecuteScalarToOrDefault&lt;string&gt;();
    ///                               var result2 = @this.ExecuteScalarToOrDefault&lt;int&gt;();
    ///                               int result3 = @this.ExecuteScalarToOrDefault(-1);
    ///                               int result4 = @this.ExecuteScalarToOrDefault(command =&gt; -2);
    ///           
    ///                               // UnitTest
    ///                               Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                               Assert.AreEqual(0, result2);
    ///                               Assert.AreEqual(-1, result3);
    ///                               Assert.AreEqual(-2, result4);
    ///                           }
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return default(T);
        }
    }

    /// <summary>
    ///     A DbCommand extension method that executes the scalar to or default operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
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
    ///               public class System_Data_Common_DbCommand_ExecuteScalarToOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteScalarToOrDefault()
    ///                   {
    ///                       const string sql = @&quot;SELECT &apos;FizzBuzz&apos; As StringColumn&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               var result1 = @this.ExecuteScalarToOrDefault&lt;string&gt;();
    ///                               var result2 = @this.ExecuteScalarToOrDefault&lt;int&gt;();
    ///                               int result3 = @this.ExecuteScalarToOrDefault(-1);
    ///                               int result4 = @this.ExecuteScalarToOrDefault(command =&gt; -2);
    ///           
    ///                               // UnitTest
    ///                               Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                               Assert.AreEqual(0, result2);
    ///                               Assert.AreEqual(-1, result3);
    ///                               Assert.AreEqual(-2, result4);
    ///                           }
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, T defaultValue)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     A DbCommand extension method that executes the scalar to or default operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
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
    ///               public class System_Data_Common_DbCommand_ExecuteScalarToOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void ExecuteScalarToOrDefault()
    ///                   {
    ///                       const string sql = @&quot;SELECT &apos;FizzBuzz&apos; As StringColumn&quot;;
    ///           
    ///                       // Examples
    ///                       using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
    ///                       {
    ///                           using (SqlCommand @this = conn.CreateCommand())
    ///                           {
    ///                               conn.Open();
    ///                               @this.CommandText = sql;
    ///                               var result1 = @this.ExecuteScalarToOrDefault&lt;string&gt;();
    ///                               var result2 = @this.ExecuteScalarToOrDefault&lt;int&gt;();
    ///                               int result3 = @this.ExecuteScalarToOrDefault(-1);
    ///                               int result4 = @this.ExecuteScalarToOrDefault(command =&gt; -2);
    ///           
    ///                               // UnitTest
    ///                               Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                               Assert.AreEqual(0, result2);
    ///                               Assert.AreEqual(-1, result3);
    ///                               Assert.AreEqual(-2, result4);
    ///                           }
    ///                       }
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T ExecuteScalarToOrDefault<T>(this DbCommand @this, Func<DbCommand, T> defaultValueFactory)
    {
        try
        {
            return @this.ExecuteScalar().To<T>();
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}