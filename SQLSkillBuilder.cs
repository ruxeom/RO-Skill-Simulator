using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class SQLSkillBuilder: SkillBuilder
    {
        public SQLSkillBuilder() { }

        public Skill BuildSkill(object[] rawdata)
        {
            int id = (int)rawdata[0];
            String name = (String)rawdata[1];
            short maxlvl = (short)rawdata[2];
            Skill skill = new Skill(id, name, maxlvl);
            
            return skill;
        }

    }
}
