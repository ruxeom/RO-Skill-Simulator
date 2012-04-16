using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class Skill
    {

        public String Name;
        //A list containing Skill/RequieredLevel pairs
        private List<Tuple<Skill, int>> RequiredSkills = new List<Tuple<Skill, int>>();
        //A list of skills that depend on this one
        private List<Skill> DependentSkills = new List<Skill>();
        private int _ID;
        private int _Maxlvl;
        private int _Currentlvl = 0;
        public int ID { get { return _ID; } }
        public int Maxlvl { get { return _Maxlvl; } }
        public int Currentlvl { get { return _Currentlvl; } }

        public Skill(int id, String name, int max)     //constructor
        {
            this._ID = id;
            this.Name = name;
            this._Maxlvl = max;
        }

        public void SetLevel(int level)                 //recursively check integrity of the tree 
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

        public void FixRequirements()                   //fix pre reqs in order to set this one
        {
            foreach (Tuple<Skill, int> req in RequiredSkills)
            {
                if (!SkillLevelOk(req.Key, req.Value))
                    req.Key.SetLevel(req.Value);
            }
        }

        public void FixDependencies()
        {
            foreach (Tuple<Skill, int> req in RequiredSkills)
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

        public void SetLevel(int level, ref List<int[]> alteredlist)
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

        public void FixRequirements(ref List<int[]> alteredlist)
        {
            foreach (Tuple<Skill, int> req in RequiredSkills)
            {
                if (!SkillLevelOk(req.Key, req.Value))
                {
                    req.Key.SetLevel(req.Value, ref alteredlist);
                }
            }
        }

        public void FixDependencies(ref List<int[]> alteredlist)
        {
            foreach (Tuple<Skill, int> req in RequiredSkills)
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

        public Boolean SkillLevelOk(Skill skill, int reqlvl)
        {
            if (skill._Currentlvl >= reqlvl)
                return true;
            return false;
        }

        public void AddRequirement(Skill reqskill, int reqlvl)     
        {
            RequiredSkills.Add(new Tuple<Skill, int>(reqskill, reqlvl));
        }

        public void AddDependency(Skill next)          
        {
            this.DependentSkills.Add(next);
        }

    }
}
