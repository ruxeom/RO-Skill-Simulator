using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class Job
    {
        //public List<Skill> Skills = new List<Skill>();
        private Dictionary<int, Skill> SkillDictionary;
        public String Name;
        public int UsedSkillPoints
        {
            get 
            {
                int temp = 0;
                foreach (Skill skill in SkillDictionary.Values)
                {
                    temp += skill.Currentlvl;
                }
                return temp;
            }
        }

        public Job()
        { }
        
        public Job(String name)
        {
            this.Name = name;
        }

        public Skill GetSkill(String skill)
        {
            foreach(Skill s in SkillDictionary.Values.ToArray<Skill>())
            {
                if (String.ReferenceEquals(s.Name, skill))
                    return s;
            }
            return null;
        }

        public Skill GetSkill(int skillid)
        {
            return SkillDictionary[skillid];
        }

        public void ModifySkillLevel(int skillid, int lvl)
        {
            Skill skill = GetSkill(skillid);
            if (skill != null)   
                skill.SetLevel(lvl);
        }

        public List<int[]> ModifySkillLevel(int skillid, int lvl, List<int[]> alteredskills)
        {
            Skill skill = GetSkill(skillid);
            if (skill != null)
                skill.SetLevel(lvl, ref alteredskills);

            return alteredskills;
        }

        public void AddSkills(List<Skill> list)
        {
            SkillDictionary = new Dictionary<int, Skill>();
            foreach (Skill skill in list)
            {
                AddSkill(skill);
            }
        }

        public void AddSkill(Skill skill)
        {
            SkillDictionary.Add(skill.ID, skill);
        }

        public void AddReqToSkill(int dependentskill, int requiredskill, int lvl)
        {
            Skill d = GetSkill(dependentskill);
            Skill r = GetSkill(requiredskill);
            if (d != null && r != null)
            {
                d.AddRequirement(r, lvl);
                r.AddDependency(d);
            }
        }

        public void BuildRequirements(ArrayList requirements)
        {
            //Name,SkillID, ReqSkillID, ReqLvl
            foreach (object[] rawdata in requirements)
            {
                short skillid = (short)rawdata[1];
                short reqskillid = (short)rawdata[2];
                short reqlvl = (short)rawdata[3];
                AddReqToSkill(skillid, reqskillid, reqlvl);
            }
        }
    }
}
