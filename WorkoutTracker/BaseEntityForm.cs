using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public abstract class BaseEntityForm<T> : Form where T : class
    {
        protected WorkoutContext db;
        protected DataGridView dataGridView = null!; // Инициализируется в InitializeComponents

        protected abstract DbSet<T> GetDbSet(WorkoutContext context);
        protected abstract void ConfigureDataGridView();
        protected abstract Form CreateInputForm(T entity, bool isEdit);
        protected abstract void InitializeButtons();

        public BaseEntityForm()
        {
            db = new WorkoutContext();
            InitializeComponents();
            LoadData();
        }

        private void InitializeComponents()
        {
            // Инициализация DataGridView
            dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoGenerateColumns = false
            };

            // Панель для кнопок
            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                FlowDirection = FlowDirection.LeftToRight
            };

            // Добавляем элементы на форму
            Controls.Add(dataGridView);
            Controls.Add(panel);

            // Инициализация кнопок в производных классах
            InitializeButtons();

            // Событие закрытия формы
            FormClosing += BaseEntityForm_FormClosing;

            // Настраиваем DataGridView
            ConfigureDataGridView();
        }

        private void LoadData()
        {
            dataGridView.DataSource = GetDbSet(db).ToList();
        }

        protected void ButtonAdd_Click(object? sender, EventArgs e)
        {
            var newEntity = Activator.CreateInstance<T>();
            var inputForm = CreateInputForm(newEntity, false);
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                GetDbSet(db).Add(newEntity);
                LoadData();
            }
        }

        protected void ButtonEdit_Click(object? sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedEntity = (T)dataGridView.SelectedRows[0].DataBoundItem;
                var inputForm = CreateInputForm(selectedEntity, true);
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    db.Update(selectedEntity);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования.");
            }
        }

        protected void ButtonDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedEntity = (T)dataGridView.SelectedRows[0].DataBoundItem;
                GetDbSet(db).Remove(selectedEntity);
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.");
            }
        }

        protected void ButtonSave_Click(object? sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Изменения сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void BaseEntityForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}