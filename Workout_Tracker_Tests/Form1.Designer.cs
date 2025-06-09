namespace Workout_Tracker_Tests
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonTestLogin = new Button();
            buttonTestAddTrainee = new Button();
            buttonTestReadExercises = new Button();
            buttonTestDeleteGroup = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(113, 26);
            textBoxUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(176, 23);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(112, 67);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(176, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonTestLogin
            // 
            buttonTestLogin.Location = new Point(113, 111);
            buttonTestLogin.Margin = new Padding(3, 2, 3, 2);
            buttonTestLogin.Name = "buttonTestLogin";
            buttonTestLogin.Size = new Size(175, 22);
            buttonTestLogin.TabIndex = 2;
            buttonTestLogin.Text = "Тест: Авторизация";
            buttonTestLogin.UseVisualStyleBackColor = true;
            buttonTestLogin.Click += buttonTestLogin_Click;
            // 
            // buttonTestAddTrainee
            // 
            buttonTestAddTrainee.Location = new Point(112, 150);
            buttonTestAddTrainee.Margin = new Padding(3, 2, 3, 2);
            buttonTestAddTrainee.Name = "buttonTestAddTrainee";
            buttonTestAddTrainee.Size = new Size(175, 22);
            buttonTestAddTrainee.TabIndex = 3;
            buttonTestAddTrainee.Text = "Тест: Добавить тренирующегося";
            buttonTestAddTrainee.UseVisualStyleBackColor = true;
            buttonTestAddTrainee.Click += buttonTestAddTrainee_Click;
            // 
            // buttonTestReadExercises
            // 
            buttonTestReadExercises.Location = new Point(112, 189);
            buttonTestReadExercises.Margin = new Padding(3, 2, 3, 2);
            buttonTestReadExercises.Name = "buttonTestReadExercises";
            buttonTestReadExercises.Size = new Size(175, 22);
            buttonTestReadExercises.TabIndex = 4;
            buttonTestReadExercises.Text = "Тест: Прочитать упражнения";
            buttonTestReadExercises.UseVisualStyleBackColor = true;
            buttonTestReadExercises.Click += buttonTestReadExercises_Click;
            // 
            // buttonTestDeleteGroup
            // 
            buttonTestDeleteGroup.Location = new Point(112, 226);
            buttonTestDeleteGroup.Margin = new Padding(3, 2, 3, 2);
            buttonTestDeleteGroup.Name = "buttonTestDeleteGroup";
            buttonTestDeleteGroup.Size = new Size(175, 22);
            buttonTestDeleteGroup.TabIndex = 5;
            buttonTestDeleteGroup.Text = "Тест: Удалить группу";
            buttonTestDeleteGroup.UseVisualStyleBackColor = true;
            buttonTestDeleteGroup.Click += buttonTestDeleteGroup_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(199, 281);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 318);
            Controls.Add(labelResult);
            Controls.Add(buttonTestDeleteGroup);
            Controls.Add(buttonTestReadExercises);
            Controls.Add(buttonTestAddTrainee);
            Controls.Add(buttonTestLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Тесты WorkoutTracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonTestLogin;
        private System.Windows.Forms.Button buttonTestAddTrainee;
        private System.Windows.Forms.Button buttonTestReadExercises;
        private System.Windows.Forms.Button buttonTestDeleteGroup;
        private System.Windows.Forms.Label labelResult;
    }
}