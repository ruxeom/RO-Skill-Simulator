using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class Skill : INode
    {

        public Skill(int id, String name, int max)     //constructor
        {
            this._ID = id;
            this.Name = name;
            this._Maxlvl = max;
        }

        public override void SetCurrentLevel(int level) //recursively check integrity of the tree 
        {                                               //while inserting
            if (level >= 0 && level <= _Maxlvl)
            {
                int prevlvl = _Currentlvl;
                _Currentlvl = level;
                if (prevlvl == 0 && level > 0)
                {
                    FixRequirements();
                }
                else if (prevlvl > level)
                {
                    FixDependencies();
                }
            }
        }

        public override void FixRequirements()                   //fix pre reqs in order to set this one
        {
            foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                    req.RequiredObject.SetCurrentLevel(req.RequiredLevel);
            }
        }

        public override void FixDependencies()
        {
            foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                {
                    this._Currentlvl = 0;
                    break;
                }
            }

            foreach (Skill dep in DependentSkills)
            {
                dep.FixDependencies();
            }
        }

        public override void SetCurrentLevel(int level, ref List<int[]> alteredlist)
        {
            if (level >= 0 && level <= _Maxlvl)
            {
                int prevlvl = _Currentlvl;
                _Currentlvl = level;

                if (alteredlist == null)
                    alteredlist = new List<int[]>();
                else
                    alteredlist.Add(new int[2] { this.GetID(), Currentlvl });

                if (prevlvl == 0 && level > 0)
                {
                    FixRequirements(ref alteredlist);
                }
                else if (prevlvl > level)
                {
                    FixDependencies(ref alteredlist);
                }
            }
        }

        public override void FixRequirements(ref List<int[]> alteredlist)
        {
            foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                {
                    req.RequiredObject.SetCurrentLevel(req.RequiredLevel, ref alteredlist);
                }
            }
        }

        public override void FixDependencies(ref List<int[]> alteredlist)
        {
            foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                {
                    this._Currentlvl = 0;
                    alteredlist.Add(new int[2]{this.GetID(), Currentlvl});
                    break;
                }
            }

            foreach (Skill dep in DependentSkills)
            {
                dep.FixDependencies(ref alteredlist);
            }
        }

        public override Boolean RequiredLevelOk(ISet requiredobj, int reqlvl)
        {
            if (requiredobj.GetCurrentLevel() >= reqlvl)
                return true;
            return false;
        }

        public override void AddRequirement(INode reqskill, int reqlvl)     
        {
            RequiredSkills.Add(new Requirement(reqskill, reqlvl));
        }

        public override void AddDependency(INode next)          
        {
            this.DependentSkills.Add(next);
        }

    }
}
