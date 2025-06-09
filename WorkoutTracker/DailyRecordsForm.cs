using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class DailyRecordsForm : BaseEntityForm<DailyRecord>
    {
        public DailyRecordsForm()
        {
            InitializeComponent();
        }

        protected override DbSet<DailyRecord> GetDbSet(WorkoutContext context)
        {
            return context.DailyRecords;
        }

        protected override void ConfigureDataGridView()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "TraineeId", DataPropertyName = "TraineeId", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "ExerciseId", DataPropertyName = "ExerciseId", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Date", DataPropertyName = "Date", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Result", DataPropertyName = "Result", ReadOnly = true });
        }

        protected override Form CreateInputForm(DailyRecord entity, bool isEdit)
        {
            return new InputForm(entity, isEdit);
        }

        protected override void InitializeButtons()
        {
            if (buttonAdd == null || buttonEdit == null || buttonDelete == null || buttonSave == null)
            {
                throw new System.NullReferenceException("One or more buttons (buttonAdd, buttonEdit, buttonDelete, buttonSave) are not initialized in DailyRecordsForm.");
            }
            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonEdit_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonSave.Click += ButtonSave_Click;
        }
    }
}