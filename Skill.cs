using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class Skill
    {
        public String Name;
        public int Maxlvl;
        public int Currentlvl = 0;
        private ArrayList Reqvalues = new ArrayList();          //tuple array of req data (string/int)
        private ArrayList reqs = new ArrayList();               //an array connecting to the req skills(skill objects)
        private ArrayList dependent = new ArrayList();          //an array of skills that depend on this one (skill objects)

        public Skill(String name, int max)            //constructor
        {
            this.Name = name;
            this.Maxlvl = max;
        }

        public void set_lvl(int lvl)                    //recursively check integrity of the tree 
        {                                               //while inserting
            if (lvl > 0 && lvl <= this.Maxlvl)
            {
                Currentlvl = lvl;
                fix_reqs();
                foreach (Skill skill in dependent)
                {
                    if (skill.lvl_is_ok(this))
                        break;
                    else
                        skill.set_lvl(0);
                }
            }
        }

        public void add_req(Tuple<String, int> tup)     //add a tuple of name and lvl of a pre req
        {   
            Reqvalues.Add(tup);
        }

        /*public void link(Skill req)                     //add a skill object of a requisite
        {
            reqs.Add(req);
        }*/

        public int get_req_lvl(Skill skill)             //get the required pre req skill lvl(int)
        {
            Boolean done= false;
            int a = 0;
            Tuple<String, int> aux = new Tuple<String, int>();
            while(!done)
            {
                aux = (Tuple<String, int>)Reqvalues[a];
                if (String.ReferenceEquals(aux.key, skill.Name))
                    done = true;
                a++;
            }
            return aux.value;
        }

        public void fix_reqs()                          //fix pre reqs in order to set this one
        {
            foreach (object r in reqs)
            {
                Skill aux = (Skill)r;
                if (lvl_is_ok(aux))
                    break;
                else
                    aux.set_lvl(get_req_lvl(aux));
            }
        }

        public Boolean lvl_is_ok(Skill skill)
        {
            int needed = get_req_lvl(skill);
            if (skill.Currentlvl >= needed)
                return true;
            else
            {
                return false;
            }
        }

        public void add_next(Skill next)                //add a dependent skill to the list
        {
            this.dependent.Add(next);
        }

    }
}
