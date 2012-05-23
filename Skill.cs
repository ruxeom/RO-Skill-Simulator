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
            foreach (Tuple<INode, int> req in RequiredSkills)
            {
                if (!SkillLevelOk(req.Key, req.Value))
                    req.Key.SetCurrentLevel(req.Value);
            }
        }

        public override void FixDependencies()
        {
            foreach (Tuple<INode, int> req in RequiredSkills)
            {
                if (!SkillLevelOk(req.Key, req.Value))
                {
                    this._Currentlvl = 0;
                    break;
                }
            }

            foreach (Skill dep in DependentSkills)
            {
                FixDependencies();
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
                    alteredlist.Add(new int[2] { ID, Currentlvl });

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
            foreach (Tuple<INode, int> req in RequiredSkills)
            {
                if (!SkillLevelOk(req.Key, req.Value))
                {
                    req.Key.SetCurrentLevel(req.Value, ref alteredlist);
                }
            }
        }

        public override void FixDependencies(ref List<int[]> alteredlist)
        {
            foreach (Tuple<INode, int> req in RequiredSkills)
            {
                if (!SkillLevelOk(req.Key, req.Value))
                {
                    this._Currentlvl = 0;
                    alteredlist.Add(new int[2]{ID, Currentlvl});
                    break;
                }
            }

            foreach (Skill dep in DependentSkills)
            {
                dep.FixDependencies(ref alteredlist);
            }
        }

        public override Boolean SkillLevelOk(INode skill, int reqlvl)
        {
            if (skill.Currentlvl >= reqlvl)
                return true;
            return false;
        }

        public override void AddRequirement(INode reqskill, int reqlvl)     
        {
            RequiredSkills.Add(new Tuple<INode, int>(reqskill, reqlvl));
        }

        public override void AddDependency(INode next)          
        {
            this.DependentSkills.Add(next);
        }

    }
}
