// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data.Common;

public static partial class DbConnectionExtension
{
    /// <summary>
    ///     A DbConnection extension method that executes the scalar as operation.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">(Optional) options for controlling the operation.</param>
    /// <returns>.</returns>
    public static T ExecuteScalarAs<T>(this DbConnection @this, string cmdText, List<KeyValuePair<string, object>> parameters = null)
    {
        using (DbCommand command = @this.CreateCommand())
        {
            command.CommandText = cmdText;

            if (parameters != null)
            {
                foreach (var keyValuePair in parameters)
                {
                    DbParameter parameter = command.CreateParameter();
                    parameter.ParameterName = keyValuePair.Key;
                    parameter.Value = keyValuePair.Value;
                    command.Parameters.Add(parameter);
                }
            }

            return (T) command.ExecuteScalar();
        }
    }
}