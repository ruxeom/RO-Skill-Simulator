﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SkillSimulator
{
    public class ROSQLExpressConnectionManager2 : RODBConnectionManager
    {
        private ROSQLExpressConnectionManager2() { }

        public static RODBConnectionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ROSQLExpressConnectionManager2();
                    instance.ConnectionString = "Data Source= ESUMIKE-PC\\SQLEXPRESS ;Initial Catalog= SkillSimulator;Integrated Security=SSPI;";
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

        public override int GetTotalUsablePoints(string jobname)
        {
            Object procedure = CreateProcedure("get_total_skill_points", jobname);
            ArrayList rawdata = ExecuteProcedure(procedure);
            object[] row = (object[])rawdata[0];
            int skillpoints = (int)row[0];
            return skillpoints;
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
