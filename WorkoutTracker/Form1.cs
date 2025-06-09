using System;
using System.Linq;
using System.Windows.Forms;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (var db = new WorkoutContext())
                {
                    db.Database.EnsureCreated();
                    if (!db.Groups.Any())
                    {
                        var group1 = new Group { Name = "Группа Начальная" };
                        var group2 = new Group { Name = "Группа Продвинутая" };
                        var group3 = new Group { Name = "Группа Профи" };
                        db.Groups.AddRange(group1, group2, group3);
                        db.SaveChanges();

                        var instructor1 = new Instructor { Name = "Анна Фитнес" };
                        var instructor2 = new Instructor { Name = "Игорь Сила" };
                        var instructor3 = new Instructor { Name = "Елена Йога" };
                        instructor1.Groups.Add(group1);
                        instructor2.Groups.Add(group2);
                        instructor3.Groups.Add(group3);
                        db.Instructors.AddRange(instructor1, instructor2, instructor3);
                        db.SaveChanges();

                        var trainee1 = new Trainee { Name = "Иван Сидоров", GroupId = group1.Id };
                        var trainee2 = new Trainee { Name = "Мария Козлова", GroupId = group2.Id };
                        var trainee3 = new Trainee { Name = "Алексей Петров", GroupId = group3.Id };
                        var trainee4 = new Trainee { Name = "Ольга Соколова", GroupId = group1.Id };
                        db.Trainees.AddRange(trainee1, trainee2, trainee3, trainee4);
                        db.SaveChanges();

                        var coach1 = new Coach { Name = "Ольга Иванова", TraineeId = trainee1.Id };
                        var coach2 = new Coach { Name = "Пётр Козлов", TraineeId = trainee2.Id };
                        var coach3 = new Coach { Name = "Сергей Петров", TraineeId = trainee3.Id };
                        db.Coaches.AddRange(coach1, coach2, coach3);
                        db.SaveChanges();

                        var exercise1 = new Exercise { Name = "Отжимания" };
                        var exercise2 = new Exercise { Name = "Приседания" };
                        var exercise3 = new Exercise { Name = "Бег" };
                        var exercise4 = new Exercise { Name = "Планка" };
                        db.Exercises.AddRange(exercise1, exercise2, exercise3, exercise4);
                        db.SaveChanges();

                        var schedule1 = new WorkoutSchedule
                        {
                            GroupId = group1.Id,
                            InstructorId = instructor1.Id,
                            ExerciseId = exercise1.Id,
                            Date = DateTime.Now,
                            TimeSlot = "08:00-08:45"
                        };
                        var schedule2 = new WorkoutSchedule
                        {
                            GroupId = group2.Id,
                            InstructorId = instructor2.Id,
                            ExerciseId = exercise2.Id,
                            Date = DateTime.Now.AddDays(1),
                            TimeSlot = "09:00-09:45"
                        };
                        var schedule3 = new WorkoutSchedule
                        {
                            GroupId = group3.Id,
                            InstructorId = instructor3.Id,
                            ExerciseId = exercise3.Id,
                            Date = DateTime.Now.AddDays(2),
                            TimeSlot = "10:00-10:45"
                        };
                        db.WorkoutSchedules.AddRange(schedule1, schedule2, schedule3);
                        db.SaveChanges();

                        var challenge1 = new ChallengeSchedule
                        {
                            GroupId = group1.Id,
                            ExerciseId = exercise1.Id,
                            Date = DateTime.Now.AddDays(3),
                            ChallengeType = "Максимум повторений"
                        };
                        var challenge2 = new ChallengeSchedule
                        {
                            GroupId = group2.Id,
                            ExerciseId = exercise2.Id,
                            Date = DateTime.Now.AddDays(4),
                            ChallengeType = "Скорость"
                        };
                        var challenge3 = new ChallengeSchedule
                        {
                            GroupId = group3.Id,
                            ExerciseId = exercise4.Id,
                            Date = DateTime.Now.AddDays(5),
                            ChallengeType = "Выносливость"
                        };
                        db.ChallengeSchedules.AddRange(challenge1, challenge2, challenge3);
                        db.SaveChanges();

                        var daily1 = new DailyRecord
                        {
                            TraineeId = trainee1.Id,
                            ExerciseId = exercise1.Id,
                            Reps = 20,
                            Date = DateTime.Now,
                            Notes = "Хорошо"
                        };
                        var daily2 = new DailyRecord
                        {
                            TraineeId = trainee2.Id,
                            ExerciseId = exercise2.Id,
                            Reps = 30,
                            Date = DateTime.Now.AddDays(-1),
                            Notes = "Усталость"
                        };
                        var daily3 = new DailyRecord
                        {
                            TraineeId = trainee3.Id,
                            ExerciseId = exercise3.Id,
                            Reps = 15,
                            Date = DateTime.Now.AddDays(-2),
                            Notes = "Средне"
                        };
                        var daily4 = new DailyRecord
                        {
                            TraineeId = trainee4.Id,
                            ExerciseId = exercise4.Id,
                            Reps = 60,
                            Date = DateTime.Now,
                            Notes = "Отлично"
                        };
                        db.DailyRecords.AddRange(daily1, daily2, daily3, daily4);
                        db.SaveChanges();

                        var challengeRecord1 = new ChallengeRecord
                        {
                            TraineeId = trainee1.Id,
                            ChallengeScheduleId = challenge1.Id,
                            Reps = 25,
                            Date = challenge1.Date
                        };
                        var challengeRecord2 = new ChallengeRecord
                        {
                            TraineeId = trainee2.Id,
                            ChallengeScheduleId = challenge2.Id,
                            Reps = 35,
                            Date = challenge2.Date
                        };
                        var challengeRecord3 = new ChallengeRecord
                        {
                            TraineeId = trainee3.Id,
                            ChallengeScheduleId = challenge3.Id,
                            Reps = 45,
                            Date = challenge3.Date
                        };
                        db.ChallengeRecords.AddRange(challengeRecord1, challengeRecord2, challengeRecord3);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void traineesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TraineesForm().Show();
        }

        private void coachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CoachesForm().Show();
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InstructorsForm().Show();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GroupsForm().Show();
        }

        private void exercisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExercisesForm().Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ScheduleForm().Show();
        }

        private void challengesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChallengesForm().Show();
        }

        private void dailyRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DailyRecordsForm().Show();
        }

        private void challengeRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChallengeRecordsForm().Show();
        }
    }
}