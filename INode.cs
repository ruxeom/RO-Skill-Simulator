using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public abstract class INode : ISet
    {
        public String Name;
        //A list containing Skill/RequieredLevel pairs
        //private List<Tuple<Skill, int>> RequiredSkills = new List<Tuple<Skill, int>>();
        //A list of skills that depend on this one
        //private List<Skill> DependentSkills = new List<Skill>();
        private int _ID;
        private int _MaxLvl;
        private int _CurrentLvl = 0;
        public int ID { get { return _ID; } }

        public void SetMaxLevel(int level)
        {
            _MaxLvl = level;
        }

        public int GetMaxLevel()
        {
            return _MaxLvl;
        }

        public int GetCurrentLevel()
        {
            return _CurrentLvl;
        }
    }
}
