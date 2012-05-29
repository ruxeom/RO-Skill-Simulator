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
    public class LoLSQLExpressConnectionManager2 : LOLDBConnectionManager
    {
        private LoLSQLExpressConnectionManager2() { }

        public static LOLDBConnectionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoLSQLExpressConnectionManager2();
                    instance.ConnectionString = "Data Source= ESUMIKE-PC\\SQLEXPRESS ;Initial Catalog= MasteriesSimulator;Integrated Security=SSPI;";
                }
                return instance;
            }
        }

        public override ArrayList GetNodes(string jobname)
        {
            SqlConnection connection = new SqlConnection(instance.ConnectionString);
            SqlCommand procedure = new SqlCommand("get_masteries", connection);
            ArrayList masterytreedata = ExecuteProcedure(procedure);
            return masterytreedata;
        }

        public override ArrayList GetEdges(string jobname)
        {
            SqlConnection connection = new SqlConnection(instance.ConnectionString);
            SqlCommand procedure = new SqlCommand("get_masteries_to_masteries", connection);
            ArrayList masterytreedata = ExecuteProcedure(procedure);
            return masterytreedata;
        }

        public override int GetSkillPoints(string jobname)
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 0;
        }

        public override int GetTotalUsablePoints(string jobname)
        {
            
            return 30;
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

        public override ArrayList GetUsablePoints(string name)
        {
            int points = GetTotalUsablePoints(name);
            ArrayList pointlist = new ArrayList();
            pointlist.Add(points);

            return pointlist;
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
                MessageBox.Show("Failed to Execute Procedure: " + command.CommandType);
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
