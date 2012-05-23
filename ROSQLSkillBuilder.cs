using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class ROSQLSkillBuilder:INodeBuilder
    {
        public ROSQLSkillBuilder() { }

        public INode BuildNode(object[] rawdata)
        {
            int id = (short)rawdata[0];
            String name = (String)rawdata[1];
            short maxlvl = (short)rawdata[2];
            Skill skill = new Skill(id, name, maxlvl);
            
            return skill;
        }

    }
}
