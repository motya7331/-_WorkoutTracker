using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Models;

namespace WorkoutTracker
{
    public partial class TraineesForm : BaseEntityForm<Trainee>
    {
        public TraineesForm()
        {
            InitializeComponent();
        }

        protected override DbSet<Trainee> GetDbSet(WorkoutContext context)
        {
            return context.Trainees;
        }

        protected override void ConfigureDataGridView()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", ReadOnly = true });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "GroupId", DataPropertyName = "GroupId", ReadOnly = true });
        }

        protected override Form CreateInputForm(Trainee entity, bool isEdit)
        {
            return new InputForm(entity, isEdit);
        }

        protected override void InitializeButtons()
        {
            if (buttonAdd == null || buttonEdit == null || buttonDelete == null || buttonSave == null)
            {
                throw new System.NullReferenceException("One or more buttons (buttonAdd, buttonEdit, buttonDelete, buttonSave) are not initialized in TraineesForm.");
            }
            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonEdit_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonSave.Click += ButtonSave_Click;
        }
    }
}