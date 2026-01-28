namespace StudyTracker
{
    partial class StudyTracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyTracker));
            this.TimerStudyTracker = new System.Windows.Forms.Timer(this.components);
            this.DetailsAboutTimer = new System.Windows.Forms.MenuStrip();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTimer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudyFor = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.maskedTextBoxTimer = new System.Windows.Forms.MaskedTextBox();
            this.btnOffTimer = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewAboutStatus = new System.Windows.Forms.ListView();
            this.ElapsedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BasedTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetailsAboutTimer.SuspendLayout();
            this.tbTimer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerStudyTracker
            // 
            this.TimerStudyTracker.Interval = 1000;
            this.TimerStudyTracker.Tick += new System.EventHandler(this.TimerStudyTracker_Tick);
            // 
            // DetailsAboutTimer
            // 
            this.DetailsAboutTimer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerToolStripMenuItem});
            this.DetailsAboutTimer.Location = new System.Drawing.Point(0, 0);
            this.DetailsAboutTimer.Name = "DetailsAboutTimer";
            this.DetailsAboutTimer.Size = new System.Drawing.Size(407, 24);
            this.DetailsAboutTimer.TabIndex = 9;
            this.DetailsAboutTimer.Text = "menuStrip1";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.timerToolStripMenuItem.Text = "Timer";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save Progress";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tbTimer
            // 
            this.tbTimer.Controls.Add(this.tabPage1);
            this.tbTimer.Controls.Add(this.tabPage2);
            this.tbTimer.Location = new System.Drawing.Point(0, 27);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.SelectedIndex = 0;
            this.tbTimer.Size = new System.Drawing.Size(1125, 726);
            this.tbTimer.TabIndex = 10;
            this.tbTimer.Click += new System.EventHandler(this.tbTimer_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtStudyFor);
            this.tabPage1.Controls.Add(this.lblTimer);
            this.tabPage1.Controls.Add(this.maskedTextBoxTimer);
            this.tabPage1.Controls.Add(this.btnOffTimer);
            this.tabPage1.Controls.Add(this.btnStartTimer);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1117, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About Timer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Study Goal";
            // 
            // txtStudyFor
            // 
            this.txtStudyFor.Location = new System.Drawing.Point(1, 137);
            this.txtStudyFor.Name = "txtStudyFor";
            this.txtStudyFor.Size = new System.Drawing.Size(208, 20);
            this.txtStudyFor.TabIndex = 14;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(165, 236);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 11;
            // 
            // maskedTextBoxTimer
            // 
            this.maskedTextBoxTimer.Location = new System.Drawing.Point(1, 54);
            this.maskedTextBoxTimer.Mask = "0:00:00";
            this.maskedTextBoxTimer.Name = "maskedTextBoxTimer";
            this.maskedTextBoxTimer.Size = new System.Drawing.Size(196, 20);
            this.maskedTextBoxTimer.TabIndex = 13;
            // 
            // btnOffTimer
            // 
            this.btnOffTimer.Location = new System.Drawing.Point(95, 80);
            this.btnOffTimer.Name = "btnOffTimer";
            this.btnOffTimer.Size = new System.Drawing.Size(107, 23);
            this.btnOffTimer.TabIndex = 12;
            this.btnOffTimer.Text = "Off";
            this.btnOffTimer.UseVisualStyleBackColor = true;
            this.btnOffTimer.Click += new System.EventHandler(this.btnOffTimer_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(1, 80);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(105, 23);
            this.btnStartTimer.TabIndex = 10;
            this.btnStartTimer.Text = "Start";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set a reminder notification";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewAboutStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1117, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewAboutStatus
            // 
            this.listViewAboutStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ElapsedTime,
            this.BasedTime,
            this.Reason,
            this.Start,
            this.End});
            this.listViewAboutStatus.GridLines = true;
            this.listViewAboutStatus.HideSelection = false;
            this.listViewAboutStatus.Location = new System.Drawing.Point(0, 0);
            this.listViewAboutStatus.Name = "listViewAboutStatus";
            this.listViewAboutStatus.Size = new System.Drawing.Size(1125, 726);
            this.listViewAboutStatus.TabIndex = 0;
            this.listViewAboutStatus.UseCompatibleStateImageBehavior = false;
            this.listViewAboutStatus.View = System.Windows.Forms.View.Details;
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.Text = "ElapsedTime";
            this.ElapsedTime.Width = 200;
            // 
            // BasedTime
            // 
            this.BasedTime.Text = "BasedTime";
            this.BasedTime.Width = 200;
            // 
            // Reason
            // 
            this.Reason.Text = "Reason";
            this.Reason.Width = 200;
            // 
            // Start
            // 
            this.Start.Text = "Start";
            this.Start.Width = 200;
            // 
            // End
            // 
            this.End.Text = "End";
            this.End.Width = 200;
            // 
            // StudyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 415);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.DetailsAboutTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.DetailsAboutTimer;
            this.MaximizeBox = false;
            this.Name = "StudyTracker";
            this.Text = "StudyTracker";
            this.DetailsAboutTimer.ResumeLayout(false);
            this.DetailsAboutTimer.PerformLayout();
            this.tbTimer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerStudyTracker;
        private System.Windows.Forms.MenuStrip DetailsAboutTimer;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabControl tbTimer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudyFor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTimer;
        private System.Windows.Forms.Button btnOffTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewAboutStatus;
        private System.Windows.Forms.ColumnHeader ElapsedTime;
        private System.Windows.Forms.ColumnHeader BasedTime;
        private System.Windows.Forms.ColumnHeader Reason;
        private System.Windows.Forms.ColumnHeader Start;
        private System.Windows.Forms.ColumnHeader End;
    }
}

