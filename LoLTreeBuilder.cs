using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    public class LoLTreeBuilder : ITreeBuilder
    {
        INodeBuilder NodeBuilder;

        public LoLTreeBuilder()
        {
            NodeBuilder = new LOLSQLMasteryBuilder();
        }

        public List<ITree> BuildTreesFromData(ArrayList nodelist)
        {
            int index = 0;
            int treeindex = 0;
            List<ITree> trees = new List<ITree>();
            
            
            ITree tree1 = new MasteryTree();
            ITree tree2 = new MasteryTree();
            ITree tree3 = new MasteryTree();

            tree1.SetID(1);
            tree2.SetID(2);
            tree3.SetID(3);

            trees.Add(tree1);
            trees.Add(tree2);
            trees.Add(tree3);

            foreach (object[] data in nodelist)
            {
                INode mastery = NodeBuilder.BuildNode(data);
                treeindex = (int)data[2];
                trees[treeindex - 1].AddNode(mastery);
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
                int masteryid = (int)data[0];
                int treeid = (int)data[1];
                int depmastery = (int)data[2];
                int reqlvl = (int)data[3];

                INode dependentmastery = GetNodeFromTrees(trees, masteryid);
                switch (depmastery)
                {
                    case (1):
                        dependentmastery.AddRequirement(trees[0], reqlvl);
                        break;
                    case (2):
                        dependentmastery.AddRequirement(trees[1], reqlvl);
                        break;
                    case(3):
                        dependentmastery.AddRequirement(trees[2], reqlvl);
                        break;
                    default:
                        INode requiredmastery = GetNodeFromTrees(trees, reqlvl);

                        if (dependentmastery != null && requiredmastery != null)
                        {
                            dependentmastery.AddRequirement(requiredmastery, reqlvl);
                            requiredmastery.AddDependency(dependentmastery);
                        }
                        break;

                }

               
            }
        }

        public INode GetNodeFromTrees(List<ITree> trees, int id)
        {
            foreach (ITree tree in trees)
            {
                Mastery temp = (Mastery)tree.GetNode(id);
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
