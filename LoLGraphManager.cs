using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class LoLGraphManager : IGraphManager
    {
        private List<ITree> Trees;

        private string Name;
        private LOLDBConnectionManager DBManager;
        private LOLSQLMasteryBuilder Builder;
        private int MaxMasteryPoints;

        public int UsedMasteryPoints
        {
            get
            {
                int points = 0;
                foreach (ITree tree in Trees)
                    points += tree.GetCurrentLevel();
                return points;
            }
        }

        public LoLGraphManager()
        {
            Trees = new List<ITree>();
            DBManager = LoLSQLExpressConnectionManager2.Instance;
            Builder = new LOLSQLMasteryBuilder();
        }

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
            int points = MaxMasteryPoints - UsedMasteryPoints;
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
            this.MaxMasteryPoints = totalpoints;
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
