
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace AdoLite.Abstractions;

public interface IDBContext : IAsyncDisposable
{
    IDatabase Database { get; }
    Task<IDbTransaction> BeginTransactionAsync();
}
