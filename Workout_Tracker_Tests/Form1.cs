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
                    db.Groups.Add(new Group { Name = "������ 1" });
                    db.SaveChanges();
                }
                if (!db.Exercises.Any())
                {
                    db.Exercises.AddRange(
                        new Exercise { Name = "���������" },
                        new Exercise { Name = "����������" },
                        new Exercise { Name = "������������" }
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
                    labelResult.Text = user != null ? "���� �����������: �����" : "���� �����������: ������";
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"���� �����������: ������ ({ex.Message})";
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
                        labelResult.Text = "���� ���������� ��������������: ������ (��� ������ � Id=1)";
                        return;
                    }

                    var newTrainee = new Trainee { Name = "�������� �������������", GroupId = 1 };
                    db.Trainees.Add(newTrainee);
                    db.SaveChanges();

                    var exists = db.Trainees.Any(t => t.Name == "�������� �������������");
                    labelResult.Text = exists ? "���� ���������� ��������������: �����" : "���� ���������� ��������������: ������";
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"���� ���������� ��������������: ������ ({ex.Message})";
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
                    labelResult.Text = exercises.Any() ? $"���� ������ ����������: ����� (������� {exercises.Count} ����������)" : "���� ������ ����������: ������ (������ ����)";
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"���� ������ ����������: ������ ({ex.Message})";
                }
            }
        }

        private void buttonTestDeleteGroup_Click(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                try
                {
                    var testGroup = new Group { Name = "�������� ������" };
                    db.Groups.Add(testGroup);
                    db.SaveChanges();

                    var groupToDelete = db.Groups.FirstOrDefault(g => g.Name == "�������� ������");
                    if (groupToDelete != null)
                    {
                        db.Groups.Remove(groupToDelete);
                        db.SaveChanges();

                        var stillExists = db.Groups.Any(g => g.Name == "�������� ������");
                        labelResult.Text = stillExists ? "���� �������� ������: ������" : "���� �������� ������: �����";
                    }
                    else
                    {
                        labelResult.Text = "���� �������� ������: ������ (������ �� �������)";
                    }
                }
                catch (Exception ex)
                {
                    labelResult.Text = $"���� �������� ������: ������ ({ex.Message})";
                }
            }
        }

        private void buttonTestLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}