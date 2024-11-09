namespace StudentManagement.Utility;
using System;
using Npgsql;

public class Database: IDatabase
{
    private readonly string _connectionString;
    private NpgsqlConnection _connection;
    
    public Database(String connectionString)
    {
        _connectionString = connectionString;
    }

    public void OpenConnection()
    {
        _connection = new NpgsqlConnection(_connectionString);
        _connection.Open();
    }

    public void CloseConnection()
    {
        if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            _connection.Close();
    }

    public NpgsqlConnection GetConnection()
    {
        return _connection;
    }
}