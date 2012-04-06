using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class SQLLinker
    {
        public SQLLinker() { }

        public static SqlConnection get_connection(string connectionString)
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

        public void main()
        {
            get_connection("Server = LAPPY-II\\SQLEXPRESS; Database = SkillSimulator; User ID = Lappy-II\\Fofo");
        }

    }
}
