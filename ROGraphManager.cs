using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    class ROGraphManager : IGraphManager
    {
        public Job CurrentJob;
        private RODBConnectionManager DBManager;
        private ROSQLSkillBuilder Builder;
        public int MaxSkillPoints;
        public int UsedSkillPoints { get { return CurrentJob.UsedSkillPoints; } }

        public ROGraphManager()
        {
            DBManager = ROSQLExpressConnectionManager.Instance;
            Builder = new ROSQLSkillBuilder();
        }

        public void AddJobName(string name)
        {
            CurrentJob.Name = name;
        }

        private ArrayList GetSkills(string jobname)
        {
            ArrayList skills = DBManager.GetNodes(jobname);
            return skills;
        }

        public List<INode> InitializeJob(string jobname)
        {
            CurrentJob = new Job(jobname);

            ArrayList rawdata = GetSkills(jobname);
            List<INode> skills = new List<INode>();
            foreach (object[] rawskill in rawdata)
            {
                INode temp = Builder.BuildNode(rawskill);
                skills.Add(temp);
            }
            CurrentJob.AddNodes(skills);
            MaxSkillPoints = GetMaxSkillPoints(jobname);
            ArrayList requirements = GetSkillRequirements(jobname);
            CurrentJob.BuildRequirements(requirements);
            return skills;
        }

        public List<int[]> ModifySkillLevel(int skillid, int lvl)
        {
            return CurrentJob.ModifyNodeLevel(skillid, lvl, null);
        }

        public int GetMaxSkillPoints(string jobname)
        {
            int skillpoints = DBManager.GetTotalSkillPoints(jobname);
            return skillpoints;
        }

        private ArrayList GetSkillRequirements(string jobname)
        {
            return DBManager.GetEdges(jobname);
        }

        public List<int[]> ModifyNodeLevel(int id, int level)
        {
            return null;
        }

        public Status GetStatus()
        {
            return null;
        }

        public void AddTree(ITree tree)
        { }
    }
}
