using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    interface ISet
    {
        void SetMaxLevel(int level);
        int GetMaxLevel();

        int GetCurrentLevel();
    }
}
