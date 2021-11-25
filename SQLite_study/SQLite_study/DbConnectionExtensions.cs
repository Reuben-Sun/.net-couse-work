using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace SQLite_study
{
    public static class DbConnectionExtensions
    {
        public static int ExecuteNonQuery(this DbConnection connection, string commandText, IList<SqliteParameter> parameters = null, int timeout = 30)
        {
            var command = connection.CreateCommand();
            command.CommandTimeout = timeout;
            command.CommandText = commandText;
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    command.Parameters.Add(p);
                }
            }
            return command.ExecuteNonQuery();
        }

        public static T ExecuteScalar<T>(this DbConnection connection, string commandText, IList<SqliteParameter> parameters = null, int timeout = 30) =>
            (T)connection.ExecuteScalar(commandText, parameters, timeout);

        private static object ExecuteScalar(this DbConnection connection, string commandText, IList<SqliteParameter> parameters, int timeout)
        {
            var command = connection.CreateCommand();
            command.CommandTimeout = timeout;
            command.CommandText = commandText;
            return command.ExecuteScalar();
        }

        public static DbDataReader ExecuteReader(this DbConnection connection, string commandText, IList<SqliteParameter> parameters = null)
        {
            var command = connection.CreateCommand();
            command.CommandText = commandText;
            if (parameters != null)
            {
                foreach (var p in parameters)
                {
                    command.Parameters.Add(p);
                }
            }
            return command.ExecuteReader();
        }
    }
}
