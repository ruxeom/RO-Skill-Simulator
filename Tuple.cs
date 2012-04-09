using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class Tuple <T, U>
    {
        public T Key;
        public U Value;

        public Tuple()
        {
 
        }

        public Tuple(T t, U u)
        {
            Key = t;
            Value = u;
        }
    }
}
