using System;
using System.Reflection;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class InputForm : Form
    {
        private readonly object entity;
        private readonly bool isEdit;

        public InputForm(object entity, bool isEdit)
        {
            this.entity = entity ?? throw new ArgumentNullException(nameof(entity));
            this.isEdit = isEdit;
            InitializeComponent();
            BuildForm();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void BuildForm()
        {
            Text = isEdit ? "Редактировать" : "Добавить";
            var properties = entity.GetType().GetProperties().Where(p => p.Name != "Id" && p.CanWrite);
            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true
            };

            foreach (var prop in properties)
            {
                var label = new Label { Text = prop.Name, Width = 100 };
                var textBox = new TextBox
                {
                    Width = 200,
                    Text = prop.GetValue(entity)?.ToString() ?? ""
                };
                textBox.Tag = prop;
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
            }

            var buttonOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Width = 100 };
            var buttonCancel = new Button { Text = "Отмена", DialogResult = DialogResult.Cancel, Width = 100 };
            panel.Controls.Add(buttonOk);
            panel.Controls.Add(buttonCancel);

            Controls.Add(panel);
            AutoSize = true;
            AcceptButton = buttonOk;
            CancelButton = buttonCancel;

            buttonOk.Click += (object? sender, EventArgs e) =>
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox textBox && textBox.Tag is PropertyInfo prop)
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(textBox.Text) && Nullable.GetUnderlyingType(prop.PropertyType) != null)
                            {
                                prop.SetValue(entity, null);
                            }
                            else if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                            {
                                if (DateTime.TryParse(textBox.Text, out var date))
                                    prop.SetValue(entity, date);
                                else
                                    throw new FormatException("Неверный формат даты.");
                            }
                            else
                            {
                                var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                                var value = Convert.ChangeType(textBox.Text, targetType);
                                prop.SetValue(entity, value);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка ввода для {prop.Name}: {ex.Message}");
                            return;
                        }
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            };
        }
    }
}