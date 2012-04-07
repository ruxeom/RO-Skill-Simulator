namespace SkillSimulator
{
    partial class SkillLinker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkbutton = new System.Windows.Forms.Button();
            this.highskillmenu = new System.Windows.Forms.ListBox();
            this.prevskillmenu = new System.Windows.Forms.ListBox();
            this.lvlmenu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.loadbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkbutton
            // 
            this.linkbutton.Location = new System.Drawing.Point(220, 316);
            this.linkbutton.Name = "linkbutton";
            this.linkbutton.Size = new System.Drawing.Size(120, 33);
            this.linkbutton.TabIndex = 0;
            this.linkbutton.Text = "&Link";
            this.linkbutton.UseVisualStyleBackColor = true;
            this.linkbutton.Click += new System.EventHandler(this.linkbutton_Click);
            // 
            // highskillmenu
            // 
            this.highskillmenu.FormattingEnabled = true;
            this.highskillmenu.Location = new System.Drawing.Point(12, 85);
            this.highskillmenu.Name = "highskillmenu";
            this.highskillmenu.ScrollAlwaysVisible = true;
            this.highskillmenu.Size = new System.Drawing.Size(202, 368);
            this.highskillmenu.TabIndex = 1;
            // 
            // prevskillmenu
            // 
            this.prevskillmenu.FormattingEnabled = true;
            this.prevskillmenu.Location = new System.Drawing.Point(346, 85);
            this.prevskillmenu.Name = "prevskillmenu";
            this.prevskillmenu.ScrollAlwaysVisible = true;
            this.prevskillmenu.Size = new System.Drawing.Size(202, 368);
            this.prevskillmenu.TabIndex = 2;
            // 
            // lvlmenu
            // 
            this.lvlmenu.DisplayMember = "(none)";
            this.lvlmenu.FormatString = "N0";
            this.lvlmenu.FormattingEnabled = true;
            this.lvlmenu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lvlmenu.Location = new System.Drawing.Point(265, 85);
            this.lvlmenu.Name = "lvlmenu";
            this.lvlmenu.Size = new System.Drawing.Size(26, 134);
            this.lvlmenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Required Skill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Skill Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skill";
            // 
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "Swordsman",
            "Thief",
            "Mage",
            "Archer",
            "Merchant",
            "Acolyte",
            "--------------------",
            "Knight",
            "Crusader",
            "Assasin",
            "Rouge",
            "Wizard",
            "Sage",
            "Hunter",
            "Bard",
            "Dancer",
            "Blacksmith",
            "Alchemist",
            "Priest",
            "Monk",
            "--------------------",
            "Lord Knight",
            "Paladin",
            "Assasin Cross",
            "Stalker",
            "High Wizard",
            "Scholar",
            "Sniper",
            "Minstrel",
            "Gypsy",
            "MasterSmith",
            "Biochemist",
            "High Priest",
            "Champion",
            "--------------------",
            "Rune Knight",
            "Royal Guard",
            "Guillotine Cross",
            "Shadow Chaser",
            "Warlock",
            "Sorcerer",
            "Ranger",
            "Maestro",
            "Wanderer",
            "Mechanic",
            "Geneticist",
            "Arch Bishop",
            "Sura",
            "--------------------",
            "Tae Kwon Kid",
            "Tae Kwon Master",
            "Soul Linker",
            "Ninja",
            "Gunslinger",
            "Super Novice"});
            this.combobox.Location = new System.Drawing.Point(277, 12);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(167, 21);
            this.combobox.TabIndex = 7;
            this.combobox.Text = "Select a Job";
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(473, 12);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(75, 23);
            this.loadbutton.TabIndex = 8;
            this.loadbutton.Text = "&Load";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Job Name";
            // 
            // SkillLinker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvlmenu);
            this.Controls.Add(this.prevskillmenu);
            this.Controls.Add(this.highskillmenu);
            this.Controls.Add(this.linkbutton);
            this.Name = "SkillLinker";
            this.Text = "SkillLinker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linkbutton;
        private System.Windows.Forms.ListBox highskillmenu;
        private System.Windows.Forms.ListBox prevskillmenu;
        private System.Windows.Forms.ListBox lvlmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.Label label4;
    }
}