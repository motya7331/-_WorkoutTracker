using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class ExercisesForm : BaseEntityForm<Exercise>
    {
        public ExercisesForm()
        {
            InitializeComponent();
        }

        protected override DbSet<Exercise> GetDbSet(WorkoutContext context)
        {
            return context.Exercises;
        }

        protected override void ConfigureDataGridView()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", DataPropertyName = "Description", ReadOnly = true });
        }

        protected override Form CreateInputForm(Exercise entity, bool isEdit)
        {
            return new InputForm(entity, isEdit);
        }

        protected override void InitializeButtons()
        {
            if (buttonAdd == null || buttonEdit == null || buttonDelete == null || buttonSave == null)
            {
                throw new System.NullReferenceException("One or more buttons (buttonAdd, buttonEdit, buttonDelete, buttonSave) are not initialized in ExercisesForm.");
            }
            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonAdd_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonSave.Click += ButtonSave_Click;
        }
    }
}