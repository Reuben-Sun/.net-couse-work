using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_study
{
    public class UserRepository : IDisposable
    {
        DbConnection connection;

        public UserRepository(string connectionString)
        {
            connection = new SqliteConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
        }

        private void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();
        }

        public void SelectFromUserTable()
        {

            string sql = @"SELECT NAME,CLASS,SCHOOL from STUDENT;";
            OpenConnection();
            var result = connection.ExecuteReader(sql);
            while (result.Read())
            {
                Console.WriteLine(string.Format("NAME: {0}", result.GetString(0)));
                Console.WriteLine(string.Format("CLASS: {0}", result.GetString(1)));
                Console.WriteLine(string.Format("SCHOOL: {0}", result.GetString(2)));
            }
        }
        public void SelectFromLogTable()
        {

            string sql = @"SELECT CONTENT from LOG;";
            OpenConnection();
            var result = connection.ExecuteReader(sql);
            while (result.Read())
            {
                Console.WriteLine(string.Format("LOG_CONTENT: {0}", result.GetString(0)));
            }
        }

        public void DeleteFromUserTable()
        {
            string sql = @"DELETE FROM STUDENT;";
            OpenConnection();
            connection.ExecuteNonQuery(sql);
        }

        public void DeleteFromLOGTable()
        {
            string sql = @"DELETE FROM LOG;";
            OpenConnection();
            connection.ExecuteNonQuery(sql);
        }

        public void InsertIntoUserTable(Student student)
        {
            string sql = @"INSERT INTO STUDENT
                            (NAME, CLASS, SCHOOL)
                        VALUES
                            (@_NAME, @_CLASS, @_SCHOOL)";
            OpenConnection();
            connection.ExecuteNonQuery(sql, new List<SqliteParameter>
            {
                new SqliteParameter("@_NAME",student.Name),
                new SqliteParameter("@_CLASS",student.Classes),
                new SqliteParameter("@_SCHOOL",student.School),
            });
        }
        public void InsertIntoLogTable(String content)
        {
            string sql = @"INSERT INTO LOG
                            (CONTENT)
                        VALUES
                            (@_CONTENT)";
            OpenConnection();
            connection.ExecuteNonQuery(sql, new List<SqliteParameter>
            {
                new SqliteParameter("@_CONTENT",content),
            });
        }

        public void CreateUserTable()
        {
            string sql = @"
                        CREATE TABLE IF NOT EXISTS STUDENT(
                            
                            [NAME] NVARCHAR(128) NOT NULL,
                            [CLASS] NVARCHAR(128) NOT NULL,
                            [SCHOOL] NVARCHAR(128) NOT NULL

                        )";
            OpenConnection();
            connection.ExecuteNonQuery(sql);
        }

        public void CreateLogTable()
        {
            string sql = @"
                        CREATE TABLE IF NOT EXISTS LOG(
                            
                            [CONTENT] NVARCHAR(128) NOT NULL
                           
                        )";
            OpenConnection();
            connection.ExecuteNonQuery(sql);
        }

        public Student GetStudentByName(string name)
        {
            try
            {
                string sql = "SELECT * From STUDENT WHERE NAME = @_NAME;";
                OpenConnection();
                var result = connection.ExecuteReader(sql, new List<SqliteParameter>
                {
                    new SqliteParameter("@_NAME",name)
                });
                if (result.Read())
                {
                    var student = new Student
                    {
                        Name = result.GetString(0),
                        Classes = result.GetString(1),
                        School = result.GetString(2)
                       
                    };
                    return student;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
