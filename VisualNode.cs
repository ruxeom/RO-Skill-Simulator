﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

public delegate void VisualSkillHandler(object sender, EventArgs e);
namespace SkillSimulator
{
    public class VisualNode : Control
    {
        //private Panel Panel;
        private Label Label;
        public NumericUpDown LevelSelector;
        private int _NodeID;
        public int NodeID { get { return this._NodeID; } }
        public event VisualSkillHandler Changed;

        protected virtual void OnChanged(Object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        //We make the constructor require a Skill object
        //because future GUI implementations might require lots of info from 
        //the skill object and too many parameters look ugly
        public VisualNode(INode node)
        {
            Label = new Label();
            LevelSelector = new NumericUpDown();

            _NodeID = node.GetID();
            Label.Text = node.GetName();

            LevelSelector.Minimum = LevelSelector.Value = 0;
            LevelSelector.Maximum = node.Maxlvl;

            Label.Height = 15;
            Label.Width = 200;
            LevelSelector.Height = 15;
            LevelSelector.Width = 40;
            this.Height = 40;
            this.Width = 380;

            this.Controls.Add(LevelSelector);
            this.Controls.Add(Label);

            LevelSelector.Location = new Point(220, 0);
            LevelSelector.ValueChanged += new EventHandler(this.OnChanged);
        }

        public void SetContainer(int height, Control container)
        {
            this.Location = new Point(0, height);
            container.Controls.Add(this);
        }
    }
}