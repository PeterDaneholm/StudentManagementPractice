using Npgsql;

namespace StudentManagement.Utility;

public interface IDatabase
{
    void OpenConnection();
    void CloseConnection();
    NpgsqlConnection GetConnection();
}