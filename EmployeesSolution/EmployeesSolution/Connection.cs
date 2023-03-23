using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeesSolution
{
    public class Connection
    {
        private string connstr;
        private string querystr = "";
        private string server;
        private string password;
        private string user;
        private string initialcatalog;
        private SqlConnection sql;
        private SqlCommand cmd;
        private SqlDataReader reader;

        public Connection(string server, string initialcatalog)
        { 
            this.server = server;
            this.initialcatalog = initialcatalog;
            CreateConnection(true);
        }

        public Connection(string server, string initialcatalog, string user, string password)
        {
            this.server = server;
            this.initialcatalog = initialcatalog;
            this.password = password;
            this.user = user;
            CreateConnection();
        }
        public void CreateConnection(bool integratedsecurity = false)
        {
            if (integratedsecurity)
                this.connstr = "Data Source = " + this.server + "; Initial Catalog = " + this.initialcatalog + "; Integrated Security=true";
            else
                this.connstr = "Data Source = " + this.server + "; Initial Catalog = " + this.initialcatalog + "; User ID = " + this.user + "; Password = " + this.password;
            this.sql = new SqlConnection(this.connstr);
            
        }

        public bool TestConnection()
        {
            bool result = false;
            if (sql != null)
            {
                try
                {
                    sql.Open();
                    result = true;
                    sql.Close();
                    MessageBox.Show("Connection Ok!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error..!\n" + ex.Message);
                }
            }
            else
                MessageBox.Show("Does not exist a SQL connection instance");
            return result;
        }

        public List<Employee> EmployeesList()
        {
            List<Employee> employees = new List<Employee>();
            querystr = "Select * from Employee order by BornDate";
            cmd = new SqlCommand(querystr, sql);
            sql.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee e = new Employee(); 
                e.ID = reader.GetInt32(0);
                e.Name = reader.GetString(1);
                e.LastName = reader.GetString(2);
                e.RFC = reader.GetString(3);
                e.BornDate = reader.GetDateTime(4);
                e.Status = (EmployeeStatus)reader.GetInt32(5);
                employees.Add(e);
            }
            sql.Close();
            return employees;
        }

        public bool existRFC(string RFC)
        {
            bool result = false;
            querystr = "Select * from Employee where RFC = @RFC";
            cmd = new SqlCommand(querystr, sql);
            cmd.Parameters.AddWithValue("@RFC", RFC);
            sql.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
               result = true;
            sql.Close();
            return result;
        }

        public int insertEmployee(Employee employee) 
        {
            int result = 0;
            querystr = "insert into Employee Values(@id, @name, @lastname, @rfc, @borndate, @estatus)";
            cmd = new SqlCommand(querystr, sql);
            cmd.Parameters.AddWithValue("@id", employee.ID);
            cmd.Parameters.AddWithValue("@name", employee.Name);
            cmd.Parameters.AddWithValue("@lastname", employee.LastName);
            cmd.Parameters.AddWithValue("@rfc", employee.RFC);
            cmd.Parameters.AddWithValue("@borndate", employee.BornDate);
            cmd.Parameters.AddWithValue("@estatus", employee.Status);
            sql.Open();
            result = cmd.ExecuteNonQuery();
            sql.Close();
            return  result;
        }
    }
}



