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
    public partial class SkillSimulatorMainGUI : Form
    {
        private String PrevSelectedJob;
        private String SelectedJob;

        private GraphManager Graph;
        private MainMenu menu;
        //SQLLinker sqlinker = new SQLLinker();

        public SkillSimulatorMainGUI()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Graph = new GraphManager();
            menu = new MainMenu();
            PrevSelectedJob = SelectedJob = "";
        }

        public void Form1_Load(object sender, EventArgs e)
        { }

        private void JobSelectorBox_TextUpdate(object sender, EventArgs e)
        {
            int a = JobSelectorBox.FindString(JobSelectorBox.Text);
            if (a >= 0 && !JobSelectorBox.Text.Equals("--------------------"))
            {
                SelectedJob = JobSelectorBox.SelectedItem.ToString();
                //NotificationLabel.Text = JobSelectorBox.Text;
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
                    VisualSkill visual = new VisualSkill(skill);
                    visual.SetContainer(10 + 40 * a, SkillContainerPanel);
                    visual.Changed += this.SkillModified;
                    a++;
                }
                JobLabel.Text = SelectedJob;
                NotificationLabel.Text = "Skill Points Left: " + Graph.MaxSkillPoints;
                NotificationLabel.ForeColor = Color.DarkBlue;
            }
        }

        public void SkillModified(object sender, EventArgs e)
        {
            VisualSkill vs = (VisualSkill)sender;
            List<int[]> modifiedskills = Graph.ModifySkillLevel(vs.SkillID, (int)vs.LevelSelector.Value);
            foreach (int[] modified in modifiedskills)
            {
                vs = FindVisualSkill(modified[0]);
                vs.LevelSelector.Value = modified[1];
            }
            int skillpoints = Graph.MaxSkillPoints - Graph.UsedSkillPoints;
            RefreshNotification(skillpoints);
        }

        public VisualSkill FindVisualSkill(int id)
        {
            VisualSkill vs = null;
            foreach (Control c in SkillContainerPanel.Controls)
            {
                VisualSkill tmp = (VisualSkill)c;
                if (tmp.SkillID == id)
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

        private void addNewSkillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.Show();
            this.Hide();
        }

        private void linkJobSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkillLinker sklinker = new SkillLinker();
            sklinker.Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement w/e this was
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement w/e this was
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { } 
    }
}