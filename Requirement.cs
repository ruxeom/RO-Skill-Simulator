using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class Requirement: Edge
    {
        protected int _RequiredLevel;
        public int RequiredLevel { get { return _RequiredLevel; } }

        public Requirement() { }

        public Requirement (ISet requiredobj, int requiredlvl)
        {
            this._RequiredObject = requiredobj;
            this._RequiredLevel = requiredlvl;
        }
    }
}
