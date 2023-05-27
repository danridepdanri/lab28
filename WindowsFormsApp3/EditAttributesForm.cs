using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class EditAttributesForm : Form
    {
        private string path;

        public EditAttributesForm(string path)
        {
            InitializeComponent();
            this.path = path;
            LoadCurrentAttributes();
        }

        private void EditAttributesForm_Load(object sender, EventArgs e)
        {
            // Завантаження поточних атрибутів файлу або каталогу
            LoadCurrentAttributes();
        }

        private void LoadCurrentAttributes()
        {
            try
            {
                if (File.Exists(path))
                {
                    FileAttributes attributes = File.GetAttributes(path);
                    attributesTextBox.Text = attributes.ToString();
                }
                else if (Directory.Exists(path))
                {
                    FileAttributes attributes = File.GetAttributes(path);
                    attributesTextBox.Text = attributes.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading current attributes: " + ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    FileAttributes attributes = (FileAttributes)Enum.Parse(typeof(FileAttributes), attributesTextBox.Text);
                    File.SetAttributes(path, attributes);
                }
                else if (Directory.Exists(path))
                {
                    FileAttributes attributes = (FileAttributes)Enum.Parse(typeof(FileAttributes), attributesTextBox.Text);
                    File.SetAttributes(path, attributes);
                }
                MessageBox.Show("Attributes updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attributes: " + ex.Message);
            }
        }
    }
}
