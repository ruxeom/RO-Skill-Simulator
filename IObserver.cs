using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public interface IObserver
    {
        void NotifySelection();
        void NotifyModification();
        void NotifySave();
        void NotifyLoad();
        void NotifyClose();
    }
}
