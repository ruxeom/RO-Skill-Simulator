using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Editor : Form
    {
        SQLLinker linker = new SQLLinker();
        public Editor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            errorlabel.Text = check_field_integrity(new Control[] { skillnameinput, jobnameinput, maxlvlinput });
            if (errorlabel.Text == "")
            {
                // if (skillnameinput.Text.Contains("'"))
                //   skillnameinput.Text.Replace("'", "\"");
                linker.execute_query(" EXECUTE add_skill '" + skillnameinput.Text + "' , " + maxlvlinput.Text + " , '" + jobnameinput.Text + "'");
                skillnameinput.Text = "";
                maxlvlinput.Text = "";
                skillnameinput.Select();
            }

        }

        public String check_field_integrity(Control[] text)
        {
            foreach (Control control in text)
            {
                if (control.Text == "")
                    return "Please fill the requiered fields.";
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorlabel.Text = check_field_integrity(new Control[] { skillnameinput, jobnameinput });
            if (errorlabel.Text == "")
                linker.execute_query(" EXECUTE delete_skill '" + skillnameinput.Text + "' , " + jobnameinput.Text);
        }

        private void skillnameinput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
