using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    public class ROTreeBuilder : ITreeBuilder
    {
        INodeBuilder NodeBuilder;

        public ROTreeBuilder()
        {
            NodeBuilder = new ROSQLSkillBuilder();
        }

        public List<ITree> BuildTreesFromData(ArrayList nodelist)
        {
            int index = 0;
            Dictionary<int, int> treeindex = new Dictionary<int, int>();
            List<ITree> trees = new List<ITree>();
            ITree temp = new Job();
            foreach (object[] data in nodelist)
            {
                int treeid = (short)data[3];

                INode skill = NodeBuilder.BuildNode(data);

                //if the tree does exist
                if (treeindex.ContainsKey(treeid))
                {
                    trees[treeindex[treeid]].AddNode(skill);
                }
                //if the tree for the node we're dealing with doesn't exist
                //we have to create it, add it and add the new node there
                else 
                {
                    Job job = new Job();
                    job.SetID(treeid);
                    job.AddNode(skill);
                    trees.Add(job);
                    treeindex.Add(treeid, index++);
                }
            }
            return trees;
        }

        public List<ITree> BuildTreesFromData(ArrayList nodelist, ArrayList UsablePoints)
        {
            List<ITree> trees = BuildTreesFromData(nodelist);
            return trees;
        }

        public void AddEdgesToTrees(List<ITree> trees, ArrayList edgedata)
        {
            foreach (object[] data in edgedata)
            {
                short skillid = (short)data[1];
                short reqskillid = (short)data[2];
                short reqlvl = (short)data[3];
                INode dependentskill = GetNodeFromTrees(trees, skillid);
                INode requiredskill = GetNodeFromTrees(trees, reqskillid);

                if (dependentskill != null && requiredskill != null)
                {
                    dependentskill.AddRequirement(requiredskill, reqlvl);
                    requiredskill.AddDependency(dependentskill);
                }
            }
        }

        public INode GetNodeFromTrees(List<ITree> trees, int id)
        {
            foreach (ITree tree in trees)
            {
                Skill temp = (Skill)tree.GetNode(id);
                if (temp != null)
                    return temp;
            }
            return null;
        }

        public List<Requirement> ApplyBuildToTrees(List<ITree> trees, ArrayList builddata)
        {
            List<Requirement> mods = new List<Requirement>();
            foreach (object[] data in builddata)
            {
                INode skill = GetNodeFromTrees(trees, (int)data[0]);
                int level = (int)data[1];
                skill.SetCurrentLevel(level);
                Requirement edge = new Requirement(skill, level);
                mods.Add(edge);
            }
            return mods;
        }
    }
}
