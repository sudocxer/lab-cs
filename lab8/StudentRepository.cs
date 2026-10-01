using System.Data;
using Microsoft.Data.SqlClient;

namespace lab8_c_
{
    internal static class StudentRepository
    {
        public static void EnsureDatabase()
        {
            using (SqlConnection connection = new SqlConnection(DbConfig.ServerConnectionString))
            {
                connection.Open();
                string sql = $"IF DB_ID('{DbConfig.DatabaseName}') IS NULL CREATE DATABASE [{DbConfig.DatabaseName}];";
                using SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }

            using (SqlConnection connection = new SqlConnection(DbConfig.ConnectionString))
            {
                connection.Open();
                string sql = @"
IF OBJECT_ID('dbo.Students', 'U') IS NULL
CREATE TABLE dbo.Students (
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    Surname    NVARCHAR(50) NOT NULL,
    Name       NVARCHAR(50) NOT NULL,
    GroupName  NVARCHAR(20) NOT NULL,
    Course     INT NOT NULL
);";
                using SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetAll()
        {
            using SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT Id, Surname, Name, GroupName, Course FROM dbo.Students ORDER BY Surname, Name",
                connection);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable Search(string surnamePattern)
        {
            using SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);
            connection.Open();

            string sql = @"
SELECT Id, Surname, Name, GroupName, Course
FROM dbo.Students
WHERE Surname LIKE @pattern
ORDER BY Surname, Name";

            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@pattern", $"%{surnamePattern}%");

            using SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        public static void Add(Student student)
        {
            using SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);
            connection.Open();

            string sql = @"
INSERT INTO dbo.Students (Surname, Name, GroupName, Course)
VALUES (@surname, @name, @group, @course)";

            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@group", student.GroupName);
            command.Parameters.AddWithValue("@course", student.Course);
            command.ExecuteNonQuery();
        }

        public static void Update(Student student)
        {
            using SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);
            connection.Open();

            string sql = @"
UPDATE dbo.Students
SET Surname = @surname, Name = @name, GroupName = @group, Course = @course
WHERE Id = @id";

            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@group", student.GroupName);
            command.Parameters.AddWithValue("@course", student.Course);
            command.Parameters.AddWithValue("@id", student.Id);
            command.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using SqlConnection connection = new SqlConnection(DbConfig.ConnectionString);
            connection.Open();

            using SqlCommand command = new SqlCommand("DELETE FROM dbo.Students WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }
    }
}
