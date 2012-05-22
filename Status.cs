using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    class Status
    {
        string Content;
        bool IsGood;

        public Status(string content, bool isgood)
        {
            Content = content;
            IsGood = isgood;
        }
    }
}
