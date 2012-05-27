using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    class ROGraphManager : IGraphManager
    {
        private List<ITree> Trees;

        private string Name;
        private RODBConnectionManager DBManager;
        private ROSQLSkillBuilder Builder;
        private int MaxSkillPoints;
        public int UsedSkillPoints 
        { 
            get 
            {
                int points = 0;
                foreach (ITree tree in Trees)
                    points += tree.GetCurrentLevel();
                return points;
            } 
        }

        public ROGraphManager()
        {
            Trees = new List<ITree>();
            DBManager = ROSQLExpressConnectionManager.Instance;
            Builder = new ROSQLSkillBuilder();
        }

        //public void AddJobName(string name)
        //{
        //    CurrentJob.Name = name;
        //}

        //private ArrayList GetSkills(string jobname)
        //{
        //    ArrayList skills = DBManager.GetNodes(jobname);
        //    return skills;
        //}

        /*public List<INode> InitializeJob(string jobname)
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
        }*/

        /*public List<int[]> ModifySkillLevel(int skillid, int lvl)
        {
            List<int[]> modifiednodes = new List<int[]>();
            return CurrentJob.ModifyNodeLevel(skillid, lvl, null);
        }*/

        //public int GetMaxSkillPoints(string jobname)
        //{
        //    int skillpoints = DBManager.GetTotalSkillPoints(jobname);
        //    return skillpoints;
        //}

        //private ArrayList GetSkillRequirements(string jobname)
        //{
        //    return DBManager.GetEdges(jobname);
        //}

        public List<int[]> ModifyNodeLevel(int skillid, int level)
        {
            List<int[]> modifiednodes = new List<int[]>();
            foreach (ITree job in Trees)
            {
                job.ModifyNodeLevel(skillid, level, modifiednodes);
            }
            return modifiednodes;
        }

        public Status GetStatus()
        {
            int points = MaxSkillPoints - UsedSkillPoints;
            if (points >= 0)
                return new Status("Rest: " + points, true);

            return new Status("Over: " + -points, false);
        }

        public void AddTree(ITree tree)
        {
            this.Trees.Add(tree);
        }

        public void AddTrees(List<ITree> trees)
        {
            /*foreach (ITree tree in trees)
                this.Trees.Add(tree);*/
            this.Trees = trees;
        }

        public List<INode> GetAllNodes()
        {
            List<INode> allnodes = new List<INode>();
            foreach (ITree t in Trees)
                allnodes.AddRange(t.GetNodes());
            return allnodes;
        }

        public void AddGlobalUsablePoints(int totalpoints)
        {
            this.MaxSkillPoints = totalpoints;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public List<ITree> GetTrees()
        {
            return this.Trees;
        }

        public void Reset()
        {
            List<INode> nodes = this.GetAllNodes();
            foreach (INode node in nodes)
                node.SetCurrentLevel(0);
        }
    }
}
