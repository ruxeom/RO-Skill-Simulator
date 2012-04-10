using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

public delegate void VisualSkillHandler(object sender, EventArgs e);

public class VisualSkill
{
    private Panel Panel;
    private Label Label;
    public NumericUpDown LevelSelector;
    private int _SkillID;
    public int SkillID { get { return this._SkillID; } }
    public event VisualSkillHandler Changed;

    protected virtual void OnChanged(Object sender, EventArgs e)
    {
        if (Changed != null)
            Changed(this, e);
    }

    public VisualSkill(String skillname, int maxlevel)
    {
        Panel = new Panel();
        Label = new Label();
        LevelSelector = new NumericUpDown();
        //this._SkillID = skillid;
        Label.Text = skillname;
        LevelSelector.Minimum = LevelSelector.Value = 0;
        LevelSelector.Maximum = maxlevel;
        Label.Height = 15;
        Label.Width = 200;
        LevelSelector.Height = 15;
        LevelSelector.Width = 40;
        Panel.Height = 40;
        Panel.Width = 380;
        LevelSelector.ValueChanged += new EventHandler(this.OnChanged);
    }

    public void SetContainer(int height, Control container)
    {
        Panel.Location = new Point(0, height);
        Label.BackColor = Color.White;
        Panel.Controls.Add(Label);
        LevelSelector.Location = new Point(220, 0);
        LevelSelector.Visible = true;
        Panel.Controls.Add(LevelSelector);
        container.Controls.Add(this.Panel);

    }
}