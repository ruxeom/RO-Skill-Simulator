using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class SkillLinker : Form
    {
        public SkillLinker()
        {
            InitializeComponent();
        }

        String selectedjob = "";
        String prevselectedjob = "";
        SQLLinker sqlinker = new SQLLinker();

        private void loadbutton_Click(object sender, EventArgs e)
        {
            int a = combobox.FindString(combobox.Text);
            if (a > -1 && !combobox.Text.Equals("--------------------") && !prevselectedjob.Equals(selectedjob))
            {
                prevselectedjob = selectedjob;
                selectedjob = combobox.SelectedItem.ToString();
                label4.Text = combobox.Text;
                clear_lists();
                ArrayList allskills = get_skill_list(get_job_tree(selectedjob));
                add_list_content(highskillmenu, allskills);
                add_list_content(prevskillmenu, allskills);
            }

        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combobox.Text.Equals("--------------------"))
            {
                selectedjob = combobox.SelectedItem.ToString();
            }
        }

        public void clear_lists()
        {
            highskillmenu.Items.Clear();
            prevskillmenu.Items.Clear();
        }

        public ArrayList get_job_tree(String job)
        {
            ArrayList names = new ArrayList();
            names.Add(job);
            String temp = get_prev_job(job);
            while (!Equals(temp, ""))
            {
                names.Insert(0,temp);
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

        public ArrayList get_skill_list(ArrayList jobtree)
        {
            ArrayList list = new ArrayList();
            foreach (String jobname in jobtree)
            {
                ArrayList skills = sqlinker.execute_query("EXECUTE get_skills '"+ jobname + "'");
                foreach (Object[] skill in skills)
                    list.Add(skill[1]);
            }
            return list;
        }

        public void add_list_content(ListBox listbox, ArrayList strings)
        {
            foreach (String name in strings)
            {
                listbox.Items.Add(name);
            }
        }

        private void linkbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
