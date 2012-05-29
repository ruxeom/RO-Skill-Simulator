using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public abstract class INode : ISet
    {
        protected String Name;
        //A list containing Skill/RequieredLevel pairs
        protected List<Requirement> RequiredSkills = new List<Requirement>();
        //A list of skills that depend on this one
        protected List<INode> DependentSkills = new List<INode>();
        protected int _ID;
        protected int _Maxlvl;
        protected int _Currentlvl = 0;
        protected int _type;
        public int Maxlvl { get { return _Maxlvl; } }
        public int Currentlvl { get { return _Currentlvl; } }

        public void SetMaxLevel(int level)
        {
            _Maxlvl = level;
        }

        public int GetMaxLevel()
        {
            return _Maxlvl;
        }

        public virtual void SetCurrentLevel(int level)
        {
            _Currentlvl = level;
        }

        public virtual void SetCurrentLevel(int level, ref List<int[]> alterednodes)
        {
            _Currentlvl = level;
        }

        public int GetCurrentLevel()
        {
            return _Currentlvl;
        }

        public void SetID(int id)
        { }

        public int GetID()
        {
            return _ID;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
        
        public int GetType()
        {
            return _type;
        }

        public abstract void AddRequirement(ISet req, int reqlevel);

        public abstract void AddDependency(INode dep);

        public abstract void FixDependencies();

        public abstract void FixRequirements();

        public abstract void FixRequirements(ref List<int[]> alteredlist);

        public abstract void FixDependencies(ref List<int[]> alteredlist);

        public abstract Boolean RequiredLevelOk(ISet Obj, int reqlvl);
    }
}
