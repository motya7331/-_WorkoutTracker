using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class CoachesForm : BaseEntityForm<Coach>
    {
        public CoachesForm()
        {
            InitializeComponent();
        }

        protected override DbSet<Coach> GetDbSet(WorkoutContext context)
        {
            return context.Coaches;
        }

        protected override void ConfigureDataGridView()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "TraineeId", DataPropertyName = "TraineeId", ReadOnly = true });
        }

        protected override Form CreateInputForm(Coach entity, bool isEdit)
        {
            return new InputForm(entity, isEdit);
        }

        protected override void InitializeButtons()
        {
            if (buttonAdd == null || buttonEdit == null || buttonDelete == null || buttonSave == null)
            {
                throw new System.NullReferenceException("One or more buttons (buttonAdd, buttonEdit, buttonDelete, buttonSave) are not initialized in CoachesForm.");
            }
            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonEdit_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonSave.Click += ButtonSave_Click;
        }
    }
}