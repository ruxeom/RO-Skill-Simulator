using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class Job
    {
        public ArrayList skills = new ArrayList();
        public String name;


        public Job()
        {
            
        }
        
        public Job(String name)
        {
            this.name = name;
        }

        public Skill get_skill(String skill)
        {
            foreach(Skill s in skills)
            {
                Skill aux = s;
                if (String.ReferenceEquals(aux.Name, skill))
                    return aux;
            }
            return null;
        }

        public void connect(String skill, String requiredskill, int lvl)
        {
            Skill s = get_skill(skill);
            Skill r = get_skill(requiredskill);
            s.add_req(new Tuple<String, int>(requiredskill, lvl));
            //s.link(r);
            r.add_next(s);
        }
    }
}
