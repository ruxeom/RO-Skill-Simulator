﻿namespace SkillSimulator
{
    partial class SkillSimulatorMainGUI
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
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ROSimulatorToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoLSimulatorToolItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JobSelectorBox = new System.Windows.Forms.ComboBox();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.SkillContainerPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolItem,
            this.SaveToolItem,
            this.NewToolItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // OpenToolItem
            // 
            this.OpenToolItem.Name = "OpenToolItem";
            this.OpenToolItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolItem.Text = "&Open";
            // 
            // SaveToolItem
            // 
            this.SaveToolItem.Name = "SaveToolItem";
            this.SaveToolItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolItem.Text = "&Save";
            // 
            // NewToolItem
            // 
            this.NewToolItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ROSimulatorToolItem,
            this.LoLSimulatorToolItem});
            this.NewToolItem.Name = "NewToolItem";
            this.NewToolItem.Size = new System.Drawing.Size(103, 22);
            this.NewToolItem.Text = "&New";
            // 
            // ROSimulatorToolItem
            // 
            this.ROSimulatorToolItem.Name = "ROSimulatorToolItem";
            this.ROSimulatorToolItem.Size = new System.Drawing.Size(147, 22);
            this.ROSimulatorToolItem.Text = "&RO Simulator";
            this.ROSimulatorToolItem.Click += new System.EventHandler(this.ROSimulatorToolItem_Click);
            // 
            // LoLSimulatorToolItem
            // 
            this.LoLSimulatorToolItem.Name = "LoLSimulatorToolItem";
            this.LoLSimulatorToolItem.Size = new System.Drawing.Size(147, 22);
            this.LoLSimulatorToolItem.Text = "&LoL Simulator";
            this.LoLSimulatorToolItem.Click += new System.EventHandler(this.LoLSimulatorToolItem_Click);
            // 
            // JobSelectorBox
            // 
            this.JobSelectorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.JobSelectorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.JobSelectorBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobSelectorBox.FormattingEnabled = true;
            this.JobSelectorBox.Items.AddRange(new object[] {
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
            this.JobSelectorBox.Location = new System.Drawing.Point(290, 39);
            this.JobSelectorBox.Name = "JobSelectorBox";
            this.JobSelectorBox.Size = new System.Drawing.Size(110, 22);
            this.JobSelectorBox.TabIndex = 1;
            this.JobSelectorBox.Text = "Select a Job";
            this.JobSelectorBox.Visible = false;
            this.JobSelectorBox.SelectedIndexChanged += new System.EventHandler(this.JobSelectorBox_TextUpdate);
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Location = new System.Drawing.Point(12, 39);
            this.NotificationLabel.MaximumSize = new System.Drawing.Size(158, 0);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(92, 13);
            this.NotificationLabel.TabIndex = 2;
            this.NotificationLabel.Text = "Select a Simulator";
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(406, 39);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(113, 22);
            this.InitializeButton.TabIndex = 3;
            this.InitializeButton.Text = "&Generate Simulator";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Visible = false;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // SkillContainerPanel
            // 
            this.SkillContainerPanel.AutoScroll = true;
            this.SkillContainerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SkillContainerPanel.Location = new System.Drawing.Point(12, 67);
            this.SkillContainerPanel.Name = "SkillContainerPanel";
            this.SkillContainerPanel.Size = new System.Drawing.Size(563, 363);
            this.SkillContainerPanel.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(526, 39);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(49, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // SkillSimulatorMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(604, 442);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.SkillContainerPanel);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.JobSelectorBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SkillSimulatorMainGUI";
            this.Text = "Skill Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolItem;
        private System.Windows.Forms.ComboBox JobSelectorBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Panel SkillContainerPanel;
        private System.Windows.Forms.ToolStripMenuItem NewToolItem;
        private System.Windows.Forms.ToolStripMenuItem ROSimulatorToolItem;
        private System.Windows.Forms.ToolStripMenuItem LoLSimulatorToolItem;
        private System.Windows.Forms.Button resetButton;


    }
}

