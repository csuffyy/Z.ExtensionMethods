// Copyright (c) 2014 Jonathan Magnan (http://zzzportal.com)
// All rights reserved.
// Licensed under MIT License (MIT)
// License can be found here: https://zextensionmethods.codeplex.com/license

using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

public static partial class SqlConnectionExtension
{
    /// <summary>
    ///     A SqlConnection extension method that executes the data table operation.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="cmdText">The command text.</param>
    /// <param name="parameters">(Optional) options for controlling the operation.</param>
    /// <returns>.</returns>
    public static DataTable ExecuteDataTable(this SqlConnection @this, string cmdText, List<KeyValuePair<string, object>> parameters = null)
    {
        using (SqlCommand command = @this.CreateCommand())
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

            var ds = new DataSet();
            using (var sqlDataAdapter = new SqlDataAdapter(command))
            {
                sqlDataAdapter.Fill(ds);
            }

            return ds.Tables[0];
        }
    }
}