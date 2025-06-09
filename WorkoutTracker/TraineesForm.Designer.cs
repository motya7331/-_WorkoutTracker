namespace WorkoutTracker
{
    partial class TraineesForm
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
            dataGridViewTrainees = new DataGridView();
            buttonAdd = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            button2 = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainees).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTrainees
            // 
            dataGridViewTrainees.AllowUserToAddRows = false;
            dataGridViewTrainees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrainees.Location = new Point(14, 14);
            dataGridViewTrainees.Margin = new Padding(4, 3, 4, 3);
            dataGridViewTrainees.Name = "dataGridViewTrainees";
            dataGridViewTrainees.ReadOnly = true;
            dataGridViewTrainees.Size = new Size(653, 346);
            dataGridViewTrainees.TabIndex = 0;
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
            buttonDelete.Size = new Size(89, 27);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(117, 0);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(316, 375);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(97, 27);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // TraineesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 417);
            Controls.Add(buttonEdit);
            Controls.Add(button2);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewTrainees);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TraineesForm";
            Text = "Тренирующиеся";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrainees).EndInit();
            ResumeLayout(false);
        }

        private  System.Windows.Forms.DataGridView dataGridViewTrainees;
        private   System.Windows.Forms.Button buttonAdd;
        private  System.Windows.Forms.Button buttonSave;
        private Button buttonDelete;
        private Button button2;
        private Button buttonEdit;
    }
}