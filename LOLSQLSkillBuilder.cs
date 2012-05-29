using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class LOLSQLMasteryBuilder:INodeBuilder
    {
        public LOLSQLMasteryBuilder() { }

        public INode BuildNode(object[] rawdata)
        {
            int id = (int)rawdata[0];
            String name = (String)rawdata[1];
            int type = (int)rawdata[2];
            int maxlvl = (int)rawdata[3];
            Mastery mastery = new Mastery(id, name, type, maxlvl);

            return mastery;
        }

    }
}
