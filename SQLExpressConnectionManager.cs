using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SkillSimulator
{
    public class SQLExpressConnectionManager : DBConnectionManager
    {
        //public SQLExpressConnectionManager() { }

        public static DBConnectionManager Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLExpressConnectionManager();
                    instance.ConnectionString = "Data Source= LAPPY-II\\SQLEXPRESS ;Initial Catalog= SkillSimulator;Integrated Security=SSPI;";
                }
                return instance;
            }
        }

        public override int GetSkillPoints(string jobname)
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 0;
        }

        public override int GetTotalSkillPoints(string jobname)
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 0;
        }

        public override Object CreateProcedure(string procedurename, string param)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(procedurename, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(
                new SqlParameter("@jobname", param));
            return command;
        }

        public override ArrayList ExecuteProcedure(Object procedure)
        {
            SqlCommand command = (SqlCommand)procedure;
            SqlDataReader reader = null;
            ArrayList data = null;

            try
            {
                data = new ArrayList();
                command.Connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    data.Add(values);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to Execute Procedure: "+ command.CommandType );
            }
            finally
            {
                if (command.Connection != null)
                {
                    command.Connection.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return data;
        }
    }
}
