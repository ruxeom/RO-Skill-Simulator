using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SkillSimulator
{
    class MasteryTree : ITree
    {
        private Dictionary<int, INode> MasteryList;
        private String Name;
        private int ID;
        public int Maxlvl;
        public int UsedSkillPoints
        {
            get
            {
                int temp = 0;
                foreach (Mastery mastery in MasteryList.Values)
                {
                    temp += mastery.Currentlvl;
                }
                return temp;
            }
        }

        public MasteryTree()
        {
            MasteryList = new Dictionary<int, INode>();
        }

        public MasteryTree(String name)
        {
            this.Name = name;
        }

        public void SetID(int id)
        {
            this.ID = id;
        }

        public int GetID()
        {
            return this.ID;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
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
            foreach (Mastery s in MasteryList.Values.ToArray<INode>())
            {
                if (String.ReferenceEquals(s.GetName(), skill))
                    return s;
            }
            return null;
        }

        public List<INode> GetNodes()
        {
            return MasteryList.Values.ToList<INode>();
        }

        public INode GetNode(int skillid)
        {
            if (MasteryList.ContainsKey(skillid))
                return MasteryList[skillid];
            return null;
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

            //to make sure the "special ones" get their attention
            foreach (Mastery m in MasteryList.Values)
            {
                if (!m.RequirementsAreOk())
                    m.SetCurrentLevel(0, ref alteredskills);
               
            }

            return alteredskills;
        }

        public void AddNodes(List<INode> list)
        {
            MasteryList = new Dictionary<int, INode>();
            foreach (Mastery m in list)
            {
                AddNode(m);
            }
        }

        public void AddNode(INode skill)
        {
            MasteryList.Add(skill.GetID(), skill);
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

        public void SetCurrentLevel(int level) { }

        public void SetCurrentLevel(int level, ref List<int[]> alteredlist) { }
    }
}
