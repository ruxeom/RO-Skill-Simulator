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
    public partial class Form1 : Form
    {
        String prevselectedjob = "";
        String selectedjob = "";

        Job job = new Job();
        MainMenu menu = new MainMenu();
        SQLLinker sqlinker = new SQLLinker();
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //ArrayList skills = get_tree_skills("Knight");
            //short a = 0;
            //foreach(Skill skill in skills)
            //{
            //    VisualSkill visual = new VisualSkill(skill.name, skill.maxlvl);
            //    visual.setComponents(10 + 50 * a, panel1);
            //    a++;
            //}

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            int a = comboBox1.FindString(comboBox1.Text);
            if (a > -1 && !comboBox1.Text.Equals("--------------------"))
            {
                selectedjob = comboBox1.SelectedItem.ToString();
                label1.Text = comboBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!prevselectedjob.Equals(selectedjob))
            {
                prevselectedjob = selectedjob;
                //job.skills = get_job_skills(selectedjob);
                panel1.Controls.Clear();
                ArrayList skills = get_tree_skills(comboBox1.Text);
                short a = 0;
                foreach (Skill skill in skills)
                {
                    VisualSkill visual = new VisualSkill(skill.Name, skill.Maxlvl);
                    visual.setComponents(10 + 50 * a, panel1);
                    a++;
                }
            }
        }

        public short get_job_id(String job)
        {
            ArrayList data = sqlinker.execute_query("dbo.get_job_id('" + job + "'");
            short id = -1;
            foreach (object[] row in data)
                id = (short)row[0];
            return id;
        }

        public ArrayList get_job_tree(String job)
        {
            ArrayList names = new ArrayList();
            names.Add(job);
            String temp = get_prev_job(job);
            while (!Equals(temp, ""))
            {
                names.Add(temp);
                temp = get_prev_job(temp);
            }
            return names;
        }

        public String get_prev_job(String job)
        {
            ArrayList prev = sqlinker.execute_query(
                "EXECUTE return_prev_job '" + job + "'");
            String temp = "";
            foreach (Object[] row in prev)
                temp = (String)row[0];
            return temp;
        }

        public ArrayList get_tree_skills(String job)
        {
            ArrayList tree = get_job_tree(job);
            ArrayList skills = new ArrayList();
            foreach (String name in tree)
            {
                skills.InsertRange(0, get_job_skills((String)name));
            }
            return skills;
        }

        public ArrayList get_job_skills(String job)
        {
            ArrayList data = sqlinker.execute_query("get_skills '" + job + "'");

            ArrayList extra = new ArrayList();
            foreach (object[] row in data)
            {
                String name = (String)row[1];
                short maxlvl = (short)row[2];
                Skill skill = new Skill(0,name, maxlvl);
                extra.Add(skill);
            }
            return extra;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public class VisualSkill
        {
            public VisualSkill(String skillname, int maxlevel)
            {
                this.label.Text = skillname;
                label.Height = 15;
                label.Width = 200;
                panel.Height = 40;
                panel.Width = 380;
                this.buttons = new RadioButton[maxlevel];
            }

            public Panel panel = new Panel();
            public Label label = new Label();
            public RadioButton[] buttons;
            public int height;

            public void setComponents(int height, Control parent)
            {
                panel.Location = new Point(5, height);
                label.BackColor = Color.White;
                panel.Controls.Add(label);
                Font b = new Font("", (float)6.5);
                for (int a = 0; a < buttons.Length; a++)
                {
                    buttons[a] = new RadioButton();
                    buttons[a].Font = b;
                    buttons[a].BackColor = Color.White;
                    buttons[a].Text = "" + (a + 1);
                    buttons[a].Location = new Point(4 + a * 35, 12);
                    buttons[a].Width = 35;
                    panel.Controls.Add(buttons[a]);
                }
                parent.Controls.Add(panel);

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

    }
}