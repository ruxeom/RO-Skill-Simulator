using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class Job : ITree
    {
        //public List<Skill> Skills = new List<Skill>();
        private Dictionary<int, INode> SkillDictionary;
        public String Name;
        public int Maxlvl;
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
        {
            SkillDictionary = new Dictionary<int, INode>();
        }
        
        public Job(String name)
        {
            this.Name = name;
        }

        public void SetMaxLevel(int level)
        {
            this.Maxlvl = level;
        }

        public int GetMaxLevel()
        {
            return this.Maxlvl;
        }

        public int GetCurrentLevel()
        {
            return UsedSkillPoints;
        }

        public INode GetNode(String skill)
        {
            foreach(Skill s in SkillDictionary.Values.ToArray<INode>())
            {
                if (String.ReferenceEquals(s.Name, skill))
                    return s;
            }
            return null;
        }

        public INode GetNode(int skillid)
        {
            return SkillDictionary[skillid];
        }

        public void ModifyNodeLevel(int skillid, int lvl)
        {
            INode skill = GetNode(skillid);
            if (skill != null)   
                skill.SetCurrentLevel(lvl);
        }

        public List<int[]> ModifyNodeLevel(int skillid, int lvl, List<int[]> alteredskills)
        {
            INode skill = GetNode(skillid);
            if (skill != null)
                skill.SetCurrentLevel(lvl, ref alteredskills);

            return alteredskills;
        }

        public void AddNodes(List<INode> list)
        {
            SkillDictionary = new Dictionary<int, INode>();
            foreach (Skill skill in list)
            {
                AddNode(skill);
            }
        }

        public void AddNode(INode skill)
        {
            SkillDictionary.Add(skill.ID, skill);
        }

        public void AddRequirementToNode(int dependentskill, int requiredskill, int lvl)
        {
            INode d = GetNode(dependentskill);
            INode r = GetNode(requiredskill);
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
                AddRequirementToNode(skillid, reqskillid, reqlvl);
            }
        }
    }
}
