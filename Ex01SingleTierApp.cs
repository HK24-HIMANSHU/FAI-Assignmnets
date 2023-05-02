using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Ex01SingleTierApp
{
    class Ex01SingleTierApp
    {
        const string STRCONNECTION = @"Data Source=W-674PY03-1;Initial Catalog=Himanshu1DB;Persist Security Info=True;User ID=sa;Password=Password@12345";
        const string selectall = "select * from tblemployee";
        static void Main(string[] args)
        {
            readrecords();
            //insertRecord("sam", 1111222234, 33333, 3, 32);
            //insertRecordUsingStoredProc("Niel", 1441222234, 54333, 3, 34);
            //deleteRecord(1016);
            //updateRecord(1017, "Hari");
        }

        private static void updateRecord(int empid, string empName)
        {
            const string STRUPDATE = "UpdateEmployee1";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRUPDATE, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empId", empid);
            cmd.Parameters.AddWithValue("@empName", empName);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void deleteRecord(int empId)
        {
            const string STRDELETE = "DeleteEmployee";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRDELETE, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empId", empId);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void insertRecordUsingStoredProc(string name, long phone, int salary, int dept, int city)
        {
            int iGenerateId = 0;
            const string STRINSERT = "InsertEmployee";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(STRINSERT,con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empName", name);
            cmd.Parameters.AddWithValue("@empSalary", salary);
            cmd.Parameters.AddWithValue("@empPhone", phone);
            cmd.Parameters.AddWithValue("@deptId", dept);
            cmd.Parameters.AddWithValue("@cityId", city);
            cmd.Parameters.AddWithValue("@empId", iGenerateId);
            cmd.Parameters[5].Direction = System.Data.ParameterDirection.Output;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private static void insertRecord(string name, long phone, int salary, int dept, int city)
        {
            var statement = $"Insert into tblEmployee values('{name}','{phone}','{salary}','{dept}',{city})";
            var con = new SqlConnection(STRCONNECTION);
            var cmd = new SqlCommand(statement, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
         
        }

        private static void readrecords()
        {
            
            SqlConnection sqlcmd = new SqlConnection();
            sqlcmd.ConnectionString = STRCONNECTION;
            try
            {
                sqlcmd.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlcmd;
                command.CommandText = selectall;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["EmpName"]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}