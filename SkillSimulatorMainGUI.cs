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

        private ROGraphManager Graph;
        private MainMenu menu;

        private List<IObserver> Subscribers;

        public SkillSimulatorMainGUI()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Graph = new ROGraphManager();
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
                
                foreach(IObserver obs in Subscribers)
                {
                    obs.NotifySelection(SelectedJob);
                }

                /*List<Skill> skills = Graph.InitializeJob(JobSelectorBox.Text);
                short a = 0;
                foreach (Skill skill in skills)
                {
                    VisualNode visual = new VisualNode(skill);
                    visual.SetContainer(10 + 40 * a, SkillContainerPanel);
                    visual.Changed += this.NodeModified;
                    a++;
                }

                NotificationLabel.Text = "Skill Points Left: " + Graph.MaxSkillPoints;
                NotificationLabel.ForeColor = Color.DarkBlue;*/
            }
        }

        public void AddVisualNodes(List<INode> nodes)
        {
            short a = 0;
            foreach (INode node in nodes)
            {
                VisualNode visual = new VisualNode(node);
                visual.SetContainer(10 + 40 * a, SkillContainerPanel);
                visual.Changed += this.NodeModified;
                a++;
            }
        }

        public void NodeModified(object sender, EventArgs e)
        {
            VisualNode vs = (VisualNode)sender;
            /*List<int[]> modifiedskills = Graph.ModifySkillLevel(vs.NodeID, (int)vs.LevelSelector.Value);
            foreach (int[] modified in modifiedskills)
            {
                vs = FindVisualSkill(modified[0]);
                vs.LevelSelector.Value = modified[1];
            }
            int skillpoints = Graph.MaxSkillPoints - Graph.UsedSkillPoints;
            RefreshNotification(skillpoints);*/
            foreach (IObserver o in Subscribers)
            {
                o.NotifyModification(vs.NodeID, (int)vs.LevelSelector.Value);
            }
        }

        public void UpdateVisualNodes(List<int[]> modifiednodes)
        {
            VisualNode vs;
            /*
             * By modifying visual nodes manually we trigger the event listener again, so the first time
             * it is called it will return a list of necessary modifications ordered from most dependent nodes 
             * to least dependent ones. So we modify the value of the visual nodes in reverse order
             * to make the second call of the listener (our "accidental" trigger) fix ONLY the least dependent 
             * node at a time, since every step of the way the previous requirements will have already
             * been satisfied. 
             */

            if (modifiednodes != null)
            {
                int[][] array = modifiednodes.ToArray();
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    vs = FindVisualSkill(array[i][0]);
                    vs.LevelSelector.Value = array[i][1];
                }
            }
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

        //public void RefreshNotification(int skillpoints)
        //{
        //    bool pointsok = (skillpoints >= 0) ? true : false;
        //    if (pointsok)
        //    {
        //        NotificationLabel.Text = "Skill Points Left: " + skillpoints;
        //        NotificationLabel.ForeColor = Color.DarkBlue;
        //    }
        //    else
        //    {
        //        NotificationLabel.Text = "Over: " + -skillpoints;
        //        NotificationLabel.ForeColor = Color.DarkRed;
        //    }
        //}

        public void SetStatus(Status status)
        {
            NotificationLabel.Text = status.Content;
            NotificationLabel.ForeColor = (status.IsGood) ? Color.DarkBlue : Color.DarkRed;
        }

        public void HideROSpecifics()
        {
            this.JobSelectorBox.Visible = false;
            this.InitializeButton.Visible = false;
        }

        public void ShowROSpecifics()
        {
            this.JobSelectorBox.Visible = true;
            this.InitializeButton.Visible = true;
        }

        private void ROSimulatorToolItem_Click(object sender, EventArgs e)
        {
            ClearVisualNodes();
            SelectedSimulator = Constants.ROSimulator;
            foreach (IObserver obs in Subscribers)
            {
                obs.NotifyNew(Constants.ROSimulator);
            }
        }

        private void LoLSimulatorToolItem_Click(object sender, EventArgs e)
        {
            ClearVisualNodes();
            SelectedSimulator = Constants.LoLSimulator;
            foreach (IObserver obs in Subscribers)
            {
                obs.NotifyNew(Constants.LoLSimulator);
            }
        }

        public void ClearVisualNodes()
        {
            //maybe remove listeners from objects?
            SkillContainerPanel.Controls.Clear();
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