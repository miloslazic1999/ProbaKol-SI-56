using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        SqlConnection sqlConnection;
        public List<Student> GetAllStudents()
        {
            var results = new List<Student>();
            using (sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                sqlConnection.Open();
                var command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM Students";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = reader.GetInt32(0);
                    student.Name = reader.GetString(1);
                    student.Index = reader.GetString(2);
                    student.Average = reader.GetDecimal(3);
                    results.Add(student);
                }

            }
            return results;
            
        }
        public void AddStudent(Student s)
        {
            using (sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
               sqlConnection.Open();
                var command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = $"INSERT INTO Students VALUES('{s.Name}','{s.Index}',{s.Average})";
                var reader = command.ExecuteNonQuery();

            }
        }

    }
}
