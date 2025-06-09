using System;
using System.Linq;
using System.Windows.Forms;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class ChallengesForm : Form
    {
        private WorkoutContext db;

        public ChallengesForm()
        {
            InitializeComponent();
            db = new WorkoutContext();
            LoadChallenges();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadChallenges()
        {
            dataGridViewChallenges.DataSource = db.ChallengeSchedules
                .Select(c => new
                {
                    c.Id,
                    GroupName = c.Group != null ? c.Group.Name ?? "Без имени" : "Нет группы",
                    ExerciseName = c.Exercise != null ? c.Exercise.Name ?? "Без имени" : "Нет упражнения",
                    c.Date,
                    c.ChallengeType
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var group = db.Groups.FirstOrDefault() ?? new Group { Name = "Группа Начальная" };
            var exercise = db.Exercises.FirstOrDefault() ?? new Exercise { Name = "Отжимания" };
            if (!db.Groups.Any()) db.Groups.Add(group);
            if (!db.Exercises.Any()) db.Exercises.Add(exercise);
            db.SaveChanges();

            var challenge = new ChallengeSchedule
            {
                GroupId = group.Id,
                ExerciseId = exercise.Id,
                Date = DateTime.Now.AddDays(1),
                ChallengeType = "Максимум повторений"
            };
            db.ChallengeSchedules.Add(challenge);
            db.SaveChanges();
            LoadChallenges();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadChallenges();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}