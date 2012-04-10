using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    interface SkillBuilder
    {
        Skill BuildSkill(object[] rawdata);
    }
}
