namespace WorkoutTracker
{
    partial class InstructorsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewInstructors = new DataGridView();
            buttonAdd = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstructors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInstructors
            // 
            dataGridViewInstructors.AllowUserToAddRows = false;
            dataGridViewInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInstructors.Location = new Point(14, 14);
            dataGridViewInstructors.Margin = new Padding(4, 3, 4, 3);
            dataGridViewInstructors.Name = "dataGridViewInstructors";
            dataGridViewInstructors.ReadOnly = true;
            dataGridViewInstructors.Size = new Size(653, 346);
            dataGridViewInstructors.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(14, 375);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(88, 27);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(117, 375);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 27);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(212, 375);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 27);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(293, 375);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(103, 27);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // InstructorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 417);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewInstructors);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InstructorsForm";
            Text = "Инструкторы";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstructors).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewInstructors;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}