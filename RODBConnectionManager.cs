using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public abstract class RODBConnectionManager: IDataManager
    {
        public string ConnectionString { get; set; }

        protected static RODBConnectionManager instance;

        protected RODBConnectionManager() {}

        public virtual ArrayList GetSkills(string jobname) 
        {
            Object procedure = CreateProcedure("get_skills", jobname);
            ArrayList skilldata = ExecuteProcedure(procedure);
            return skilldata;
        }

        public virtual ArrayList GetNodes(string jobname) 
        {
            Object procedure = CreateProcedure("get_skill_tree", jobname);
            ArrayList skilltreedata = ExecuteProcedure(procedure);
            return skilltreedata;
        }

        public virtual ArrayList GetEdges(string jobname)
        {
            Object procedure = CreateProcedure("get_skill_reqs", jobname);
            ArrayList requirements = ExecuteProcedure(procedure);
            return requirements;
        }

        public virtual int GetSkillPoints(string jobname) 
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 0;
        }

        public abstract ArrayList GetUsablePoints(string name);

        public virtual int GetTotalUsablePoints(string jobname) 
        {
            //managing individual parts of the objects received 
            //may vary and will be left to implement
            return 0;
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

        public ArrayList GetBuild(string name)
        {
            return null;
        }
        
        public void SaveBuild(string game, string type, List<INode> nodes)
        { }
    }
}
