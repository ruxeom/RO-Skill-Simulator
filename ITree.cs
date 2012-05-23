using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public interface ITree : ISet
    {
        void SetMaxLevel(int level);

        int GetMaxLevel();

        int GetCurrentLevel();

        void ModifyNodeLevel(int id, int level);

        List<int[]> ModifyNodeLevel(int id, int lvl, List<int[]> alterednodes);

        void AddNode(INode node);

        void AddNodes(List<INode> nodes);

        INode GetNode(int id);

        void AddRequirementToNode(int dependentnode, int requirednode, int level);

    }
}
