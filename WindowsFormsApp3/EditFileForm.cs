using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class EditFileForm : Form
    {
        private string filePath;

        public EditFileForm(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            try
            {
                string fileContent = File.ReadAllText(filePath);
                fileContentTextBox.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
                Close();
            }
        }

        private void EditFileForm_Load(object sender, EventArgs e)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                fileContentTextBox.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
                Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(filePath, fileContentTextBox.Text);
                MessageBox.Show("File saved successfully.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }
    }
}
