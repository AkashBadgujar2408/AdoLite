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

public class DBContext : IDBContext
{
    private readonly SqlConnection _connection;
    private readonly IDatabase _database;

    public DBContext(DBContextOptions options)
    {
        _connection = new SqlConnection(options.ConnectionString);
        _database = new Database(_connection);
    }

    public IDatabase Database => _database;

    public async Task<IDbTransaction> BeginTransactionAsync()
    {
        if (_connection.State != ConnectionState.Open)
            await _connection.OpenAsync();

        return await _connection.BeginTransactionAsync();
    }

    public async ValueTask DisposeAsync()
    {
        if (null != _connection)
            await _connection.DisposeAsync();
    }
}
