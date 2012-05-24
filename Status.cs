using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class Status
    {
        private string _Content;
        private bool _IsGood;
        public string Content { get { return _Content; } }
        public bool IsGood { get { return _IsGood; } }

        public Status(string content, bool isgood)
        {
            _Content = content;
            _IsGood = isgood;
        }
    }
}
