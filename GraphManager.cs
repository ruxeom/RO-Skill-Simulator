using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    class GraphManager
    {
        public Job CurrentJob;
        private DBConnectionManager DBManager;
        private SkillBuilder Builder;
        public int MaxSkillPoints;
        public int UsedSkillPoints { get { return CurrentJob.UsedSkillPoints; } }

        public GraphManager()
        {
            DBManager = SQLExpressConnectionManager.Instance;
            Builder = new SQLSkillBuilder();
        }

        public void AddJobName(string name)
        {
            CurrentJob.Name = name;
        }

        private ArrayList GetSkills(string jobname)
        {
            ArrayList skills = DBManager.GetSkills(jobname);
            return skills;
        }

        public List<Skill> InitializeJob(string jobname)
        {
            CurrentJob = new Job(jobname);

            ArrayList rawdata = GetSkills(jobname);
            List<Skill> skills = new List<Skill>();
            foreach (object[] rawskill in rawdata)
            {
                Skill temp = Builder.BuildSkill(rawskill);
                skills.Add(temp);
            }
            CurrentJob.AddSkills(skills);
            MaxSkillPoints = GetMaxSkillPoints(jobname);
            ArrayList requirements = GetSkillRequirements(jobname);
            CurrentJob.BuildRequirements(requirements);
            return skills;
        }

        public List<int[]> ModifySkillLevel(int skillid, int lvl)
        {
            return CurrentJob.ModifySkillLevel(skillid, lvl, null);
        }

        public int GetMaxSkillPoints(string jobname)
        {
            int skillpoints = DBManager.GetTotalSkillPoints(jobname);
            MaxSkillPoints = skillpoints;
            return skillpoints;
        }

        private ArrayList GetSkillRequirements(string jobname)
        {
            return DBManager.GetSkillRequirements(jobname);
        }

    }
}
