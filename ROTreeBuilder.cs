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

        List<ITree> ITreeBuilder.BuildTreesFromData(ArrayList nodelist)
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
                    job.AddNode(skill);
                    trees.Add(job);
                    treeindex.Add(treeid, index++);
                }
            }
            return trees;
        }

        public void AddEdgesToTrees(List<ITree> trees, ArrayList EdgeData)
        {
            
        }
        /*
         * public void BuildRequirements(ArrayList requirements)
        {
            //Name,SkillID, ReqSkillID, ReqLvl
            foreach (object[] rawdata in requirements)
            {
                short skillid = (short)rawdata[1];
                short reqskillid = (short)rawdata[2];
                short reqlvl = (short)rawdata[3];
                AddRequirementToNode(skillid, reqskillid, reqlvl);
            }
        }
         */
    }
}
