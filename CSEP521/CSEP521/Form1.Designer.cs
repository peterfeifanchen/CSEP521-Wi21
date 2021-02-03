namespace CSEP521 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stableMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proposalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigPropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iterateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigIterateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primeTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korseltTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upDownN = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.upDownReps = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownReps)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stableMatchingToolStripMenuItem,
            this.primeTestingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stableMatchingToolStripMenuItem
            // 
            this.stableMatchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permuteToolStripMenuItem,
            this.initMatchingToolStripMenuItem,
            this.proposalToolStripMenuItem,
            this.bigPropToolStripMenuItem,
            this.iterateToolStripMenuItem,
            this.bigIterateToolStripMenuItem});
            this.stableMatchingToolStripMenuItem.Name = "stableMatchingToolStripMenuItem";
            this.stableMatchingToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.stableMatchingToolStripMenuItem.Text = "StableMatching";
            // 
            // permuteToolStripMenuItem
            // 
            this.permuteToolStripMenuItem.Name = "permuteToolStripMenuItem";
            this.permuteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.permuteToolStripMenuItem.Text = "Permute";
            this.permuteToolStripMenuItem.Click += new System.EventHandler(this.OnPermuteClick);
            // 
            // initMatchingToolStripMenuItem
            // 
            this.initMatchingToolStripMenuItem.Name = "initMatchingToolStripMenuItem";
            this.initMatchingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.initMatchingToolStripMenuItem.Text = "InitMatching";
            this.initMatchingToolStripMenuItem.Click += new System.EventHandler(this.OnInitMatching);
            // 
            // proposalToolStripMenuItem
            // 
            this.proposalToolStripMenuItem.Name = "proposalToolStripMenuItem";
            this.proposalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.proposalToolStripMenuItem.Text = "Proposal";
            this.proposalToolStripMenuItem.Click += new System.EventHandler(this.OnProposeClick);
            // 
            // bigPropToolStripMenuItem
            // 
            this.bigPropToolStripMenuItem.Name = "bigPropToolStripMenuItem";
            this.bigPropToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bigPropToolStripMenuItem.Text = "BigProp";
            this.bigPropToolStripMenuItem.Click += new System.EventHandler(this.OnBigPropClick);
            // 
            // iterateToolStripMenuItem
            // 
            this.iterateToolStripMenuItem.Name = "iterateToolStripMenuItem";
            this.iterateToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.iterateToolStripMenuItem.Text = "Iterate";
            this.iterateToolStripMenuItem.Click += new System.EventHandler(this.OnIterateClick);
            // 
            // bigIterateToolStripMenuItem
            // 
            this.bigIterateToolStripMenuItem.Name = "bigIterateToolStripMenuItem";
            this.bigIterateToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bigIterateToolStripMenuItem.Text = "BigIterate";
            this.bigIterateToolStripMenuItem.Click += new System.EventHandler(this.OnBigIterateClick);
            // 
            // primeTestingToolStripMenuItem
            // 
            this.primeTestingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupTableToolStripMenuItem,
            this.powerTableToolStripMenuItem,
            this.korseltTestToolStripMenuItem});
            this.primeTestingToolStripMenuItem.Name = "primeTestingToolStripMenuItem";
            this.primeTestingToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.primeTestingToolStripMenuItem.Text = "PrimeTesting";
            // 
            // groupTableToolStripMenuItem
            // 
            this.groupTableToolStripMenuItem.Name = "groupTableToolStripMenuItem";
            this.groupTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupTableToolStripMenuItem.Text = "Group Table";
            this.groupTableToolStripMenuItem.Click += new System.EventHandler(this.OnGroupTableClick);
            // 
            // powerTableToolStripMenuItem
            // 
            this.powerTableToolStripMenuItem.Name = "powerTableToolStripMenuItem";
            this.powerTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerTableToolStripMenuItem.Text = "Power Table";
            this.powerTableToolStripMenuItem.Click += new System.EventHandler(this.OnPowerTableClick);
            // 
            // korseltTestToolStripMenuItem
            // 
            this.korseltTestToolStripMenuItem.Name = "korseltTestToolStripMenuItem";
            this.korseltTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korseltTestToolStripMenuItem.Text = "Test Function";
            this.korseltTestToolStripMenuItem.Click += new System.EventHandler(this.TestFunctionClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1108, 702);
            this.textBox1.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(1279, 24);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.OnRunButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1129, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "N:";
            // 
            // upDownN
            // 
            this.upDownN.Location = new System.Drawing.Point(1153, 24);
            this.upDownN.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.upDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownN.Name = "upDownN";
            this.upDownN.Size = new System.Drawing.Size(120, 20);
            this.upDownN.TabIndex = 5;
            this.upDownN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1126, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(281, 177);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1126, 239);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(281, 371);
            this.textBox3.TabIndex = 7;
            // 
            // upDownReps
            // 
            this.upDownReps.Location = new System.Drawing.Point(1411, 24);
            this.upDownReps.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownReps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownReps.Name = "upDownReps";
            this.upDownReps.Size = new System.Drawing.Size(101, 20);
            this.upDownReps.TabIndex = 8;
            this.upDownReps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1360, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reps:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1509, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Count:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(1553, 28);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 20);
            this.countTextBox.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1428, 56);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(225, 177);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1428, 239);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(225, 371);
            this.textBox5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 732);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.upDownReps);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.upDownN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSEP 521";
            this.Click += new System.EventHandler(this.OnRunButtonClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownReps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stableMatchingToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem primeTestingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permuteToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown upDownN;
        private System.Windows.Forms.ToolStripMenuItem initMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proposalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iterateToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown upDownReps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.ToolStripMenuItem bigPropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigIterateToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem groupTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korseltTestToolStripMenuItem;
    }
}

