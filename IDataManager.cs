using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    public interface IDataManager
    {
        ArrayList GetNodes(string treename);
        ArrayList GetEdges(string treename);
        ArrayList GetUsablePoints(string name);
        int GetTotalUsablePoints(string name);
        ArrayList GetBuildNames();
        ArrayList GetBuild(string name);
        void SaveBuild(string game, string type, ArrayList edges);
    }
}
