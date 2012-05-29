using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class Mastery : INode
    {
        public Mastery(int id, String name, int type, int max)
        {
            this._ID = id;
            this.Name = name;
            this._type = type;
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

            foreach (Mastery dep in DependentSkills)
            {
                dep.FixDependencies();
            }
        }

        public override void SetCurrentLevel(int level, ref List<int[]> alteredlist)
        {
            bool canbemodified = true;

            if (level >= 0 && level <= _Maxlvl)
            {
                int prevlvl = _Currentlvl;

                if (alteredlist == null)
                    alteredlist = new List<int[]>(); 

                if (prevlvl == 0 && level > 0)
                {
                    canbemodified = FixMasteryRequirements(ref alteredlist);
                }
                else if (prevlvl > level)
                {
                    FixDependencies(ref alteredlist);
                }
                if (canbemodified)
                {
                    _Currentlvl = level;
                    alteredlist.Add(new int[2] { this.GetID(), Currentlvl });
                }
            }
        }

        public override void FixRequirements(ref List<int[]> alteredlist)
        {
            /*foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                {
                    if (req.RequiredObject.GetID() <= 3) //this req is a tree
                        continue;
                    req.RequiredObject.SetCurrentLevel(req.RequiredLevel, ref alteredlist);
                }
            }*/
        }

        public bool FixMasteryRequirements(ref List<int[]> alteredlist)
        {
            bool canbemodified = true;
            foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                {
                    if (req.RequiredObject.GetID() <= 3) //this req is a tree
                        canbemodified = false;
                    else
                        req.RequiredObject.SetCurrentLevel(req.RequiredLevel, ref alteredlist);
                }
            }
            return canbemodified;
        }

        public override void FixDependencies(ref List<int[]> alteredlist)
        {
            foreach (Requirement req in RequiredSkills)
            {
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                {
                    this._Currentlvl = 0;
                    alteredlist.Add(new int[2] { this.GetID(), Currentlvl });
                    break;
                }
            }

            foreach (Mastery dep in DependentSkills)
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

        public bool RequirementsAreOk()
        {
            foreach (Requirement req in RequiredSkills)
                if (!RequiredLevelOk(req.RequiredObject, req.RequiredLevel))
                    return false;
            return true;
        }

        public override void AddRequirement(ISet reqskill, int reqlvl)
        {
            RequiredSkills.Add(new Requirement(reqskill, reqlvl));
        }

        public override void AddDependency(INode next)
        {
            this.DependentSkills.Add(next);
        }
    }
}
