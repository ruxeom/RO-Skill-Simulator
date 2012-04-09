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
            Skill skill = new Skill(0,"",0);
            return skill;
        }

    }
}
