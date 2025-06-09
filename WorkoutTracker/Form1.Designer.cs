namespace WorkoutTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            traineesToolStripMenuItem = new ToolStripMenuItem();
            coachesToolStripMenuItem = new ToolStripMenuItem();
            instructorsToolStripMenuItem = new ToolStripMenuItem();
            groupsToolStripMenuItem = new ToolStripMenuItem();
            exercisesToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            challengesToolStripMenuItem = new ToolStripMenuItem();
            dailyRecordsToolStripMenuItem = new ToolStripMenuItem();
            challengeRecordsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { traineesToolStripMenuItem, coachesToolStripMenuItem, instructorsToolStripMenuItem, groupsToolStripMenuItem, exercisesToolStripMenuItem, scheduleToolStripMenuItem, challengesToolStripMenuItem, dailyRecordsToolStripMenuItem, challengeRecordsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(908, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // traineesToolStripMenuItem
            // 
            traineesToolStripMenuItem.Name = "traineesToolStripMenuItem";
            traineesToolStripMenuItem.Size = new Size(111, 20);
            traineesToolStripMenuItem.Text = "Тренирующиеся";
            traineesToolStripMenuItem.Click += traineesToolStripMenuItem_Click;
            // 
            // coachesToolStripMenuItem
            // 
            coachesToolStripMenuItem.Name = "coachesToolStripMenuItem";
            coachesToolStripMenuItem.Size = new Size(67, 20);
            coachesToolStripMenuItem.Text = "Тренеры";
            coachesToolStripMenuItem.Click += coachesToolStripMenuItem_Click;
            // 
            // instructorsToolStripMenuItem
            // 
            instructorsToolStripMenuItem.Name = "instructorsToolStripMenuItem";
            instructorsToolStripMenuItem.Size = new Size(93, 20);
            instructorsToolStripMenuItem.Text = "Инструкторы";
            instructorsToolStripMenuItem.Click += instructorsToolStripMenuItem_Click;
            // 
            // groupsToolStripMenuItem
            // 
            groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            groupsToolStripMenuItem.Size = new Size(61, 20);
            groupsToolStripMenuItem.Text = "Группы";
            groupsToolStripMenuItem.Click += groupsToolStripMenuItem_Click;
            // 
            // exercisesToolStripMenuItem
            // 
            exercisesToolStripMenuItem.Name = "exercisesToolStripMenuItem";
            exercisesToolStripMenuItem.Size = new Size(88, 20);
            exercisesToolStripMenuItem.Text = "Упражнения";
            exercisesToolStripMenuItem.Click += exercisesToolStripMenuItem_Click;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(152, 20);
            scheduleToolStripMenuItem.Text = "Расписание тренировок";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // challengesToolStripMenuItem
            // 
            challengesToolStripMenuItem.Name = "challengesToolStripMenuItem";
            challengesToolStripMenuItem.Size = new Size(82, 20);
            challengesToolStripMenuItem.Text = "Челленджи";
            challengesToolStripMenuItem.Click += challengesToolStripMenuItem_Click;
            // 
            // dailyRecordsToolStripMenuItem
            // 
            dailyRecordsToolStripMenuItem.Name = "dailyRecordsToolStripMenuItem";
            dailyRecordsToolStripMenuItem.Size = new Size(152, 20);
            dailyRecordsToolStripMenuItem.Text = "Ежедневные результаты";
            dailyRecordsToolStripMenuItem.Click += dailyRecordsToolStripMenuItem_Click;
            // 
            // challengeRecordsToolStripMenuItem
            // 
            challengeRecordsToolStripMenuItem.Name = "challengeRecordsToolStripMenuItem";
            challengeRecordsToolStripMenuItem.Size = new Size(152, 20);
            challengeRecordsToolStripMenuItem.Text = "Результаты челленджей";
            challengeRecordsToolStripMenuItem.Click += challengeRecordsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 484);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Workout Tracker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem traineesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challengesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem challengeRecordsToolStripMenuItem;
    }
}