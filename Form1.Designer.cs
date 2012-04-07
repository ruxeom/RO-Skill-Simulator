namespace SkillSimulator
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolopen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsave = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkJobSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolopen,
            this.toolsave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolopen
            // 
            this.toolopen.Name = "toolopen";
            this.toolopen.Size = new System.Drawing.Size(103, 22);
            this.toolopen.Text = "&Open";
            // 
            // toolsave
            // 
            this.toolsave.Name = "toolsave";
            this.toolsave.Size = new System.Drawing.Size(103, 22);
            this.toolsave.Text = "&Save";
            this.toolsave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSkillToolStripMenuItem,
            this.linkJobSkillsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewSkillToolStripMenuItem
            // 
            this.addNewSkillToolStripMenuItem.Name = "addNewSkillToolStripMenuItem";
            this.addNewSkillToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addNewSkillToolStripMenuItem.Text = "Add New Skill";
            this.addNewSkillToolStripMenuItem.Click += new System.EventHandler(this.addNewSkillToolStripMenuItem_Click);
            // 
            // linkJobSkillsToolStripMenuItem
            // 
            this.linkJobSkillsToolStripMenuItem.Name = "linkJobSkillsToolStripMenuItem";
            this.linkJobSkillsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.linkJobSkillsToolStripMenuItem.Text = "Link Job Skills";
            this.linkJobSkillsToolStripMenuItem.Click += new System.EventHandler(this.linkJobSkillsToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Swordsman",
            "Thief",
            "Mage",
            "Archer",
            "Merchant",
            "Acolyte",
            "--------------------",
            "Knight",
            "Crusader",
            "Assassin",
            "Rogue",
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
            "Assassin Cross",
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
            this.comboBox1.Location = new System.Drawing.Point(423, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 22);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select a Job";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Generate Simulator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 333);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(571, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Skill Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolopen;
        private System.Windows.Forms.ToolStripMenuItem toolsave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkJobSkillsToolStripMenuItem;


    }
}

