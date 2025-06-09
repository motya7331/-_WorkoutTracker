using System;
using System.Linq;
using System.Windows.Forms;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class ChallengeRecordsForm : Form
    {
        private WorkoutContext db;

        public ChallengeRecordsForm()
        {
            InitializeComponent();
            db = new WorkoutContext();
            LoadChallengeRecords();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadChallengeRecords()
        {
            dataGridViewChallengeRecords.DataSource = db.ChallengeRecords
                .Select(c => new
                {
                    c.Id,
                    TraineeName = c.Trainee != null ? c.Trainee.Name ?? "Без имени" : "Нет тренирующегося",
                    ChallengeType = c.ChallengeSchedule != null ? c.ChallengeSchedule.ChallengeType ?? "Без типа" : "Нет челленджа",
                    ExerciseName = c.ChallengeSchedule != null && c.ChallengeSchedule.Exercise != null ? c.ChallengeSchedule.Exercise.Name ?? "Без имени" : "Нет упражнения",
                    c.Reps,
                    c.Date
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var trainee = db.Trainees.FirstOrDefault() ?? new Trainee
            {
                Name = "Иван Сидоров",
                GroupId = db.Groups.FirstOrDefault()?.Id ?? 1
            };
            var challenge = db.ChallengeSchedules.FirstOrDefault() ?? new ChallengeSchedule
            {
                GroupId = db.Groups.FirstOrDefault()?.Id ?? 1,
                ExerciseId = db.Exercises.FirstOrDefault()?.Id ?? 1,
                Date = DateTime.Now,
                ChallengeType = "Максимум повторений"
            };
            if (!db.Trainees.Any()) db.Trainees.Add(trainee);
            if (!db.ChallengeSchedules.Any()) db.ChallengeSchedules.Add(challenge);
            db.SaveChanges();

            var challengeRecord = new ChallengeRecord
            {
                TraineeId = trainee.Id,
                ChallengeScheduleId = challenge.Id,
                Reps = 20,
                Date = challenge.Date
            };
            db.ChallengeRecords.Add(challengeRecord);
            db.SaveChanges();
            LoadChallengeRecords();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadChallengeRecords();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}