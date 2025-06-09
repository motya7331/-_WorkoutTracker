using System;
using System.Linq;
using System.Windows.Forms;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                var user = db.Users
                    .FirstOrDefault(u => u.Username == textBoxUsername.Text && u.Password == textBoxPassword.Text);
                if (user != null)
                {
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    labelError.Text = "Неверный логин или пароль";
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (var db = new WorkoutContext())
            {
                db.EnsureDatabaseCreated(); 
                if (!db.Users.Any())
                {
                    db.Users.Add(new User { Username = "admin", Password = "123" });
                    db.SaveChanges();
                }
            }
        }
    }
}