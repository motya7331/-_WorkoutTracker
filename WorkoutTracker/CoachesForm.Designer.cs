namespace WorkoutTracker
{
    partial class CoachesForm
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
            dataGridViewCoaches = new DataGridView();
            buttonAdd = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoaches).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCoaches
            // 
            dataGridViewCoaches.AllowUserToAddRows = false;
            dataGridViewCoaches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCoaches.Location = new Point(14, 14);
            dataGridViewCoaches.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCoaches.Name = "dataGridViewCoaches";
            dataGridViewCoaches.ReadOnly = true;
            dataGridViewCoaches.Size = new Size(653, 346);
            dataGridViewCoaches.TabIndex = 0;
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
            buttonDelete.Location = new Point(214, 375);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 27);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(295, 375);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(95, 27);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // CoachesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 417);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewCoaches);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CoachesForm";
            Text = "Тренеры";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCoaches).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewCoaches;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}