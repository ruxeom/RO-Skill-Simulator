namespace WindowsFormsApplication1
{
    partial class Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.skillnameinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobnameinput = new System.Windows.Forms.TextBox();
            this.maxlvlinput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill name:";
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(186, 103);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(75, 23);
            this.confirmbutton.TabIndex = 4;
            this.confirmbutton.Text = "&Insert skill";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // skillnameinput
            // 
            this.skillnameinput.Location = new System.Drawing.Point(161, 12);
            this.skillnameinput.Name = "skillnameinput";
            this.skillnameinput.Size = new System.Drawing.Size(100, 20);
            this.skillnameinput.TabIndex = 1;
            this.skillnameinput.TextChanged += new System.EventHandler(this.skillnameinput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job name:";
            // 
            // jobnameinput
            // 
            this.jobnameinput.Location = new System.Drawing.Point(161, 64);
            this.jobnameinput.Name = "jobnameinput";
            this.jobnameinput.Size = new System.Drawing.Size(100, 20);
            this.jobnameinput.TabIndex = 3;
            // 
            // maxlvlinput
            // 
            this.maxlvlinput.Location = new System.Drawing.Point(161, 38);
            this.maxlvlinput.Name = "maxlvlinput";
            this.maxlvlinput.Size = new System.Drawing.Size(100, 20);
            this.maxlvlinput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maximum Job Level:";
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Location = new System.Drawing.Point(21, 157);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 13);
            this.errorlabel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.maxlvlinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobnameinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skillnameinput);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.label1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.TextBox skillnameinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobnameinput;
        private System.Windows.Forms.TextBox maxlvlinput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Button button1;
    }
}