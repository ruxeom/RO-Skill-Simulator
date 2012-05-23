using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public interface IObserver
    {
        void NotifyNew(int type);
        void NotifyModification(int id, int lvl);
        void NotifySave();
        void NotifyLoad();
        void NotifyClose();
        void NotifySelection(string name);
    }
}
