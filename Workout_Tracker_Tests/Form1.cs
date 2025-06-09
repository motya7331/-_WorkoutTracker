using System;
using System.Linq;
using System.Windows.Forms;
using Workout_Tracker_Tests.Models;

namespace Workout_Tracker_Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                if (!db.Users.Any())
                {
                    db.Users.Add(new User { Username = "admin", Password = "123" });
                    db.SaveChanges();
                }
                if (!db.Groups.Any())
                {
                    db.Groups.Add(new Group { Name = "Группа 1" });
                    db.SaveChanges();
                }
                if (!db.Exercises.Any())
                {
                    db.Exercises.AddRange(
                        new Exercise { Name = "Отжимания" },
                        new Exercise { Name = "Приседания" },
                        new Exercise { Name = "Подтягивания" }
                    );
                    db.SaveChanges();
                }
            }
        }

        private void buttonTestLogin_Click(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                try
                {
                    var user = db.Users
                        .FirstOrDefault(u => u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text);
                    labelResult.Text = user != null ? "Тест авторизации: Успех" : "Тест авторизации: Ошибка";
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"Тест авторизации: Ошибка ({ex.Message})";
                }
            }
        }

        private void buttonTestAddTrainee_Click(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                try
                {
                    if (!db.Groups.Any(g => g.Id == 1))
                    {
                        labelResult.Text = "Тест добавления тренирующегося: Ошибка (нет группы с Id=1)";
                        return;
                    }

                    var newTrainee = new Trainee { Name = "Тестовый Тренирующийся", GroupId = 1 };
                    db.Trainees.Add(newTrainee);
                    db.SaveChanges();

                    var exists = db.Trainees.Any(t => t.Name == "Тестовый Тренирующийся");
                    labelResult.Text = exists ? "Тест добавления тренирующегося: Успех" : "Тест добавления тренирующегося: Ошибка";
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"Тест добавления тренирующегося: Ошибка ({ex.Message})";
                }
            }
        }

        private void buttonTestReadExercises_Click(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                try
                {
                    var exercises = db.Exercises.ToList();
                    labelResult.Text = exercises.Any() ? $"Тест чтения упражнений: Успех (найдено {exercises.Count} упражнений)" : "Тест чтения упражнений: Ошибка (список пуст)";
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"Тест чтения упражнений: Ошибка ({ex.Message})";
                }
            }
        }

        private void buttonTestDeleteGroup_Click(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                try
                {
                    var testGroup = new Group { Name = "Тестовая Группа" };
                    db.Groups.Add(testGroup);
                    db.SaveChanges();

                    var groupToDelete = db.Groups.FirstOrDefault(g => g.Name == "Тестовая Группа");
                    if (groupToDelete != null)
                    {
                        db.Groups.Remove(groupToDelete);
                        db.SaveChanges();

                        var stillExists = db.Groups.Any(g => g.Name == "Тестовая Группа");
                        labelResult.Text = stillExists ? "Тест удаления группы: Ошибка" : "Тест удаления группы: Успех";
                    }
                    else
                    {
                        labelResult.Text = "Тест удаления группы: Ошибка (группа не найдена)";
                    }
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"Тест удаления группы: Ошибка ({ex.Message})";
                }
            }
        }

        private void buttonTestLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}