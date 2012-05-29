using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class LOLDBConnectionManager : IDataManager
    {
        public string ConnectionString { get; set; }

        protected static LOLDBConnectionManager instance;

        protected LOLDBConnectionManager() { }

        public IDataManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new LOLDBConnectionManager();
                return instance;
            }
        }

        public virtual ArrayList GetSkills(string jobname)
        {
            Object procedure = CreateProcedure("get_skills", jobname);
            ArrayList skilldata = ExecuteProcedure(procedure);
            return null;
        }

        public virtual ArrayList GetNodes(string jobname)
        {
            Object procedure = CreateProcedure("get_masteries", jobname);
            ArrayList skilltreedata = ExecuteProcedure(procedure);
            return skilltreedata;
        }

        public virtual ArrayList GetEdges(string jobname)
        {
            Object procedure = CreateProcedure("get_mastery_to_mastery", jobname);
            ArrayList requirements = ExecuteProcedure(procedure);
            return requirements;
        }

        public virtual int GetSkillPoints(string jobname)
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 0;
        }

        public virtual ArrayList GetUsablePoints(string name)
        { return null; }

        public virtual int GetTotalUsablePoints(string jobname)
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 30;
        }

        public virtual Object CreateProcedure(string procedurename, string param)
        {
            //will vary depending on the DB used
            return null;
        }

        public virtual ArrayList ExecuteProcedure(Object procedure)
        {
            //will vary depending on the DB used
            return null;
        }

        public ArrayList GetBuildNames()
        {
            return null;
        }

        public ArrayList GetBuild()
        {
            return null;
        }

        public void SaveBuild(string game, string type, List<INode> nodes)
        { }

        //public List<Requirement> 
    }
}
