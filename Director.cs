using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkillSimulator
{
    public class Director: IObserver
    {
        private SkillSimulatorMainGUI GUI;

        public void NotifySelection() 
        {
            MessageBox.Show("changed value to: " + GUI.SelectedSimulator);
        }
        public void NotifyModification() { }
        public void NotifySave() { }
        public void NotifyLoad() { }
        public void NotifyClose() { }

        public Director()
        {
            GUI = new SkillSimulatorMainGUI();
            GUI.Subscribe(this);
            Application.Run(GUI);
        }
    }
}
