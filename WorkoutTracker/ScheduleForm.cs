using System;
using System.Linq;
using System.Windows.Forms;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class ScheduleForm : Form
    {
        private WorkoutContext db;

        public ScheduleForm()
        {
            InitializeComponent();
            db = new WorkoutContext();
            LoadSchedules();
            buttonAdd.Click += buttonAdd_Click;
            buttonSave.Click += buttonSave_Click;
        }

        private void LoadSchedules()
        {
            dataGridViewSchedules.DataSource = db.WorkoutSchedules
                .Select(s => new
                {
                    s.Id,
                    GroupName = s.Group != null ? s.Group.Name ?? "Без имени" : "Нет группы",
                    InstructorName = s.Instructor != null ? s.Instructor.Name ?? "Без имени" : "Нет инструктора",
                    ExerciseName = s.Exercise != null ? s.Exercise.Name ?? "Без имени" : "Нет упражнения",
                    s.Date,
                    s.TimeSlot
                })
                .ToList();
        }

        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            var group = db.Groups.FirstOrDefault() ?? new Group { Name = "Группа Начальная" };
            var instructor = db.Instructors.FirstOrDefault() ?? new Instructor { Name = "Анна Фитнес" };
            var exercise = db.Exercises.FirstOrDefault() ?? new Exercise { Name = "Отжимания" };
            if (!db.Groups.Any()) db.Groups.Add(group);
            if (!db.Instructors.Any()) db.Instructors.Add(instructor);
            if (!db.Exercises.Any()) db.Exercises.Add(exercise);
            db.SaveChanges();

            var schedule = new WorkoutSchedule
            {
                GroupId = group.Id,
                InstructorId = instructor.Id,
                ExerciseId = exercise.Id,
                Date = DateTime.Now,
                TimeSlot = "10:00-10:45"
            };
            db.WorkoutSchedules.Add(schedule);
            db.SaveChanges();
            LoadSchedules();
        }

        private void buttonSave_Click(object? sender, EventArgs e)
        {
            db.SaveChanges();
            LoadSchedules();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            db.Dispose();
            base.OnFormClosing(e);
        }
    }
}