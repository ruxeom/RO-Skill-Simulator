using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class Edge
    {
        protected ISet _RequiredObject;
        public ISet RequiredObject { get { return _RequiredObject; } }

        public Edge() { }

        public Edge(ISet requiredobj)
        {
            this._RequiredObject = requiredobj;
        }
    }
}
