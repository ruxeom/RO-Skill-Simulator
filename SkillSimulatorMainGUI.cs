using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkillSimulator
{
    public partial class SkillSimulatorMainGUI : Form, IGUIManager
    {
        public int SelectedSimulator;
        private String PrevSelectedJob;
        private String SelectedJob;

        private GraphManager Graph;
        private MainMenu menu;

        private List<IObserver> Subscribers;

        public SkillSimulatorMainGUI()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Graph = new GraphManager();
            menu = new MainMenu();
            Subscribers = new List<IObserver>();
            PrevSelectedJob = SelectedJob = "";
        }

        private void JobSelectorBox_TextUpdate(object sender, EventArgs e)
        {
            int a = JobSelectorBox.FindString(JobSelectorBox.Text);
            if (a >= 0 && !JobSelectorBox.Text.Equals("--------------------"))
            {
                SelectedJob = JobSelectorBox.SelectedItem.ToString();
            }
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            if (!PrevSelectedJob.Equals(SelectedJob))
            {
                PrevSelectedJob = SelectedJob;
                SkillContainerPanel.Controls.Clear();
                //maybe remove listeners from objects?

                List<Skill> skills = Graph.InitializeJob(JobSelectorBox.Text);
                short a = 0;
                foreach (Skill skill in skills)
                {
                    VisualNode visual = new VisualNode(skill);
                    visual.SetContainer(10 + 40 * a, SkillContainerPanel);
                    visual.Changed += this.NodeModified;
                    a++;
                }

                NotificationLabel.Text = "Skill Points Left: " + Graph.MaxSkillPoints;
                NotificationLabel.ForeColor = Color.DarkBlue;
            }
        }

        public void NodeModified(object sender, EventArgs e)
        {
            VisualNode vs = (VisualNode)sender;
            List<int[]> modifiedskills = Graph.ModifySkillLevel(vs.NodeID, (int)vs.LevelSelector.Value);
            foreach (int[] modified in modifiedskills)
            {
                vs = FindVisualSkill(modified[0]);
                vs.LevelSelector.Value = modified[1];
            }
            int skillpoints = Graph.MaxSkillPoints - Graph.UsedSkillPoints;
            RefreshNotification(skillpoints);
        }

        public VisualNode FindVisualSkill(int id)
        {
            VisualNode vs = null;
            foreach (Control c in SkillContainerPanel.Controls)
            {
                VisualNode tmp = (VisualNode)c;
                if (tmp.NodeID == id)
                {
                    vs = tmp;
                    break;
                }
            }
            return vs;
        }

        public void RefreshNotification(int skillpoints)
        {
            bool pointsok = (skillpoints >= 0) ? true : false;
            if (pointsok)
            {
                NotificationLabel.Text = "Skill Points Left: " + skillpoints;
                NotificationLabel.ForeColor = Color.DarkBlue;
            }
            else
            {
                NotificationLabel.Text = "Over: " + -skillpoints;
                NotificationLabel.ForeColor = Color.DarkRed;
            }
        }

        private void ROSimulatorToolItem_Click(object sender, EventArgs e)
        {
            SelectedSimulator = Constants.ROSimulator;
            foreach (IObserver obs in Subscribers)
            {
                obs.NotifySelection();
            }
        }

        private void LoLSimulatorToolItem_Click(object sender, EventArgs e)
        {
            SelectedSimulator = Constants.LoLSimulator;
            foreach (IObserver obs in Subscribers)
            {
                obs.NotifySelection();
            }
        }

        public void Subscribe(IObserver observer)
        {
            Subscribers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            foreach (IObserver obs in Subscribers)
            {
                if (obs.Equals(observer))
                {
                    Subscribers.Remove(obs);
                    break;
                }
            }
        }

    }
}