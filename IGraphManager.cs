using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public interface IGraphManager
    {
        void AddTree(ITree tree);
        void AddTrees(List<ITree> trees);
        List<INode> GetAllNodes();
        List<int[]> ModifyNodeLevel(int id, int level);
        Status GetStatus();
        void AddGlobalUsablePoints(int points);
        void SetName(string name);
        string GetName();
        List<ITree> GetTrees();
        void Reset();
    }
}
