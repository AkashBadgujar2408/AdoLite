using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
namespace AdoLite.Abstractions;

public interface IDatabase
{
    Task<IDataReader> ExecuteReaderAsync(DbCommand dbCommand);
    Task<IDataReader> ExecuteReaderAsync(string storedProcedure);
    Task<IDataReader> ExecuteReaderAsync(string storedProcedure, params SqlParameter[] parameters);
    Task<int> ExecuteNonQueryAsync(DbCommand dbCommand);
    Task<int> ExecuteNonQueryAsync(string storedProcedure);
    Task<int> ExecuteNonQueryAsync(string storedProcedure, params SqlParameter[] parameters);
    Task<IDictionary<string, object>> ExecuteIDictionaryAsync(DbCommand dbCommand);
    Task<T> ExecuteObjectAsync<T>(DbCommand dbCommand);
}
