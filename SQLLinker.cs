using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillSimulator
{
    class SQLLinker
    {
        public SQLLinker() { }

        public SqlConnection get_connection(string connectionString)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure");
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
            return connection;
        }



        public void connect_to_SQL()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source= LAPPY-II\\SQLEXPRESS ;Initial Catalog= SkillSimulator;Integrated Security=SSPI;";

            try
            {
                conn.Open();
                MessageBox.Show("Successfuly connected to data source");
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                conn.Close();
            }
        }

        public ArrayList execute_query(String sqlcommand)
        {
            ArrayList data = new ArrayList();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source= ESUMIKE-PC\\SQLEXPRESS ;Initial Catalog= SkillSimulator;Integrated Security=SSPI;";

            SqlCommand command = new SqlCommand(sqlcommand, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    data.Add(values);
                }
                //MessageBox.Show("Query Executed Successfuly");
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to Execute Query: " + sqlcommand);
            }
            finally
            {
                connection.Close();
            }

            return data;

        }
    }
}
