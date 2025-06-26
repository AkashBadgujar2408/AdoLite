using AdoLite.Abstractions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLite.Core;

public class Database : IDatabase
{
    private readonly SqlConnection _connection;

    public Database(SqlConnection sqlConnection)
    {
        _connection = sqlConnection;
    }

    public Task<IDictionary<string, object>> ExecuteIDictionaryAsync(DbCommand dbCommand)
    {
        throw new NotImplementedException();
    }

    public Task<int> ExecuteNonQueryAsync(DbCommand dbCommand)
    {
        throw new NotImplementedException();
    }

    public Task<int> ExecuteNonQueryAsync(string storedProcedure)
    {
        throw new NotImplementedException();
    }

    public Task<int> ExecuteNonQueryAsync(string storedProcedure, params SqlParameter[] parameters)
    {
        throw new NotImplementedException();
    }

    public Task<T> ExecuteObjectAsync<T>(DbCommand dbCommand)
    {
        throw new NotImplementedException();
    }

    public Task<IDataReader> ExecuteReaderAsync(DbCommand dbCommand)
    {
        throw new NotImplementedException();
    }

    public Task<IDataReader> ExecuteReaderAsync(string storedProcedure)
    {
        throw new NotImplementedException();
    }

    public Task<IDataReader> ExecuteReaderAsync(string storedProcedure, params SqlParameter[] parameters)
    {
        throw new NotImplementedException();
    }
}
