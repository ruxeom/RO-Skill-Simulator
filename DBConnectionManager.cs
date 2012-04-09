using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public abstract class DBConnectionManager
    {
        public string ConnectionString { get; set; }

        protected static DBConnectionManager instance;

        protected DBConnectionManager() {}

        public virtual ArrayList GetSkills(string jobname) 
        {
            Object procedure = CreateProcedure("get_skills", jobname);
            ArrayList skilldata = ExecuteProcedure(procedure);
            return skilldata;
        }

        public virtual ArrayList GetSkillTree(string jobname) 
        {
            Object procedure = CreateProcedure("get_skill_tree", jobname);
            ArrayList skilltreedata = ExecuteProcedure(procedure);
            return skilltreedata;
        }

        public virtual ArrayList GetSkillRequirements(string jobname)
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

        public virtual int GetTotalSkillPoints(string jobname) 
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
    }
}
