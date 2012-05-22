using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    interface IGraphManager
    {
        void AddTree(ITree tree);
        List<int[]> ModifyNodeLevel(int id, int level);
        Status GetStatus();
    }
}
