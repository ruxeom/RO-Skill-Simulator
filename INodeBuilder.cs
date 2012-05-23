using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    interface INodeBuilder
    {
        INode BuildNode(object[] rawdata);
    }
}
