using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    abstract class ITree : ISet
    {
        protected int _MaxLvl;
        protected List<INode> Nodes;

        public void SetMaxLevel(int level)
        {
            _MaxLvl = level;
        }

        public int GetMaxLevel()
        {
            return _MaxLvl;
        }

        public abstract int GetCurrentLevel()
        {
            return 0;
        }

        public abstract void ModifyNodeLevel(int id, int level)
        { }

        public abstract void AddNode(INode node)
        { }

        public abstract void AddNodes(List<INode> nodes)
        { }

        public abstract INode GetNode(INode node)
        {
            return null;
        }

        public abstract void AddDependencyToNode(int dependentnode, int requirednode, int level)
        { }

    }
}
