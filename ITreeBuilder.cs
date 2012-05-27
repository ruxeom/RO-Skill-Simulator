using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    public interface ITreeBuilder
    {
        List<ITree> BuildTreesFromData(ArrayList nodelist);
        void AddEdgesToTrees(List<ITree> trees, ArrayList EdgeData);
        List<Requirement> ApplyBuildToTrees(List<ITree> trees, ArrayList BuildData);
    }
}
