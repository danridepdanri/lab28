using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression; // Додано директиву using
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                drivesListBox.Items.Add(drive);
            }
        }

        private void drivesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drivesListBox.SelectedItem != null)
            {
                string selectedDrive = drivesListBox.SelectedItem.ToString();
                DisplayDriveProperties(selectedDrive);
                LoadDirectories(selectedDrive);
                LoadFiles(selectedDrive);
            }
        }

        private void directoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDirectory = directoriesListBox.SelectedItem.ToString();
            DisplayDirectoryProperties(selectedDirectory);
            LoadFiles(selectedDirectory);
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFile = filesListBox.SelectedItem.ToString();
            DisplayFileProperties(selectedFile);
            if (IsImageFile(selectedFile))
            {
                DisplayImage(selectedFile);
            }
            else if (IsTextFile(selectedFile))
            {
                DisplayTextFileContent(selectedFile);
            }
        }

        private void LoadDirectories(string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                directoriesListBox.Items.Clear();
                foreach (string directory in directories)
                {
                    directoriesListBox.Items.Add(directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading directories: " + ex.Message);
            }
        }

        private void LoadFiles(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                filesListBox.Items.Clear();
                foreach (string file in files)
                {
                    filesListBox.Items.Add(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading files: " + ex.Message);
            }
        }

        private void DisplayDriveProperties(string drive)
        {
            DriveInfo driveInfo = new DriveInfo(drive);
            propertiesTextBox.Text = $"Drive Name: {driveInfo.Name}\r\n" +
                $"Drive Type: {driveInfo.DriveType}\r\n" +
                $"Total Size: {driveInfo.TotalSize}\r\n" +
                $"Available Free Space: {driveInfo.AvailableFreeSpace}\r\n";
        }

        private void DisplayDirectoryProperties(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            propertiesTextBox.Text = $"Directory Name: {directoryInfo.Name}\r\n" +
                $"Created: {directoryInfo.CreationTime}\r\n" +
                $"Last Modified: {directoryInfo.LastWriteTime}\r\n" +
                $"Attributes: {directoryInfo.Attributes}\r\n";
        }

        private void DisplayFileProperties(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            propertiesTextBox.Text = $"File Name: {fileInfo.Name}\r\n" +
                $"Size: {fileInfo.Length}\r\n" +
                $"Created: {fileInfo.CreationTime}\r\n" +
                $"Last Modified: {fileInfo.LastWriteTime}\r\n" +
                $"Attributes: {fileInfo.Attributes}\r\n";
        }

        private void DisplayImage(string imagePath)
        {
            try
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void DisplayTextFileContent(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                contentTextBox.Text = content;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying text file content: " + ex.Message);
            }
        }

        private bool IsImageFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return Array.Exists(imageExtensions, ext => ext.Equals(extension, StringComparison.OrdinalIgnoreCase));
        }

        private bool IsTextFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] textExtensions = { ".txt", ".csv", ".log" };
            return Array.Exists(textExtensions, ext => ext.Equals(extension, StringComparison.OrdinalIgnoreCase));
        }

        private void createDirectoryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newDirectoryNameTextBox.Text))
            {
                string selectedPath = GetCurrentSelectedPath();
                string newDirectoryPath = Path.Combine(selectedPath, newDirectoryNameTextBox.Text);

                try
                {
                    Directory.CreateDirectory(newDirectoryPath);
                    LoadDirectories(selectedPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating directory: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid directory name.");
            }
        }

        private void copyDirectoryButton_Click(object sender, EventArgs e)
        {
            string selectedDirectory = GetCurrentSelectedDirectory();

            if (!string.IsNullOrWhiteSpace(selectedDirectory))
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationPath = folderBrowserDialog.SelectedPath;
                        try
                        {
                            CopyDirectory(selectedDirectory, destinationPath);
                            LoadDirectories(Path.GetDirectoryName(selectedDirectory));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error copying directory: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a directory to copy.");
            }
        }

        private void deleteDirectoryButton_Click(object sender, EventArgs e)
        {
            string selectedDirectory = GetCurrentSelectedDirectory();

            if (!string.IsNullOrWhiteSpace(selectedDirectory))
            {
                var result = MessageBox.Show("Are you sure you want to delete this directory and its contents?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(selectedDirectory, true);
                        LoadDirectories(Path.GetDirectoryName(selectedDirectory));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting directory: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a directory to delete.");
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newFileNameTextBox.Text))
            {
                string selectedPath = GetCurrentSelectedPath();
                string newFilePath = Path.Combine(selectedPath, newFileNameTextBox.Text);

                try
                {
                    File.Create(newFilePath).Dispose();
                    LoadFiles(selectedPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid file name.");
            }
        }

        private void copyFileButton_Click(object sender, EventArgs e)
        {
            string selectedFile = GetCurrentSelectedFile();

            if (!string.IsNullOrWhiteSpace(selectedFile))
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationFilePath = openFileDialog.FileName;
                        try
                        {
                            File.Copy(selectedFile, destinationFilePath);
                            LoadFiles(Path.GetDirectoryName(selectedFile));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error copying file: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file to copy.");
            }
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            string selectedFile = GetCurrentSelectedFile();

            if (!string.IsNullOrWhiteSpace(selectedFile))
            {
                var result = MessageBox.Show("Are you sure you want to delete this file?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(selectedFile);
                        LoadFiles(Path.GetDirectoryName(selectedFile));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting file: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file to delete.");
            }
        }

        private string GetCurrentSelectedPath()
        {
            if (!string.IsNullOrWhiteSpace(directoriesListBox.SelectedItem?.ToString()))
            {
                return directoriesListBox.SelectedItem.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(drivesListBox.SelectedItem?.ToString()))
            {
                return drivesListBox.SelectedItem.ToString();
            }

            return null;
        }

        private string GetCurrentSelectedDirectory()
        {
            return directoriesListBox.SelectedItem?.ToString();
        }

        private string GetCurrentSelectedFile()
        {
            return filesListBox.SelectedItem?.ToString();
        }

        private void CopyDirectory(string sourceDirectory, string destinationDirectory)
        {
            DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourceDirectory);
            DirectoryInfo destinationDirectoryInfo = new DirectoryInfo(destinationDirectory);

            CopyAllFiles(sourceDirectoryInfo, destinationDirectoryInfo);
            CopyAllDirectories(sourceDirectoryInfo, destinationDirectoryInfo);
        }

        private void CopyAllFiles(DirectoryInfo source, DirectoryInfo destination)
        {
            if (!destination.Exists)
            {
                destination.Create();
            }

            foreach (FileInfo file in source.GetFiles())
            {
                file.CopyTo(Path.Combine(destination.FullName, file.Name), true);
            }
        }

        private void CopyAllDirectories(DirectoryInfo source, DirectoryInfo destination)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                DirectoryInfo destinationSubDir = destination.CreateSubdirectory(dir.Name);
                CopyAllFiles(dir, destinationSubDir);
                CopyAllDirectories(dir, destinationSubDir);
            }
        }

        private void editAttributesButton_Click(object sender, EventArgs e)
        {
            string selectedPath = GetCurrentSelectedPath();

            if (!string.IsNullOrWhiteSpace(selectedPath))
            {
                using (var form = new EditAttributesForm(selectedPath))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadDirectories(Path.GetDirectoryName(selectedPath));
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file or directory to edit attributes.");
            }
        }

        private void editFileButton_Click(object sender, EventArgs e)
        {
            string selectedFile = GetCurrentSelectedFile();

            if (!string.IsNullOrWhiteSpace(selectedFile))
            {
                using (var form = new EditFileForm(selectedFile))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadFiles(Path.GetDirectoryName(selectedFile));
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file to edit.");
            }
        }

        private void compressButton_Click(object sender, EventArgs e)
        {
            string selectedFile = GetCurrentSelectedFile();

            if (!string.IsNullOrWhiteSpace(selectedFile))
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "ZIP Files (*.zip)|*.zip";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string compressedFilePath = saveFileDialog.FileName;

                        try
                        {
                            ZipFile.CreateFromDirectory(selectedFile, compressedFilePath);
                            MessageBox.Show("File compressed successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error compressing file: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file to compress.");
            }
        }

        private void decompressButton_Click(object sender, EventArgs e)
        {
            string selectedFile = GetCurrentSelectedFile();

            if (!string.IsNullOrWhiteSpace(selectedFile) && Path.GetExtension(selectedFile) == ".zip")
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationPath = folderBrowserDialog.SelectedPath;

                        try
                        {
                            ZipFile.ExtractToDirectory(selectedFile, destinationPath);
                            MessageBox.Show("File decompressed successfully.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error decompressing file: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid ZIP file to decompress.");
            }
        }

        private void moveFileButton_Click(object sender, EventArgs e)
        {
            string selectedFile = GetCurrentSelectedFile();

            if (!string.IsNullOrWhiteSpace(selectedFile))
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationFilePath = openFileDialog.FileName;
                        try
                        {
                            File.Move(selectedFile, destinationFilePath);
                            LoadFiles(Path.GetDirectoryName(selectedFile));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error moving file: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a file to move.");
            }
        }

        private void moveDirectoryButton_Click(object sender, EventArgs e)
        {
            string selectedDirectory = GetCurrentSelectedDirectory();

            if (!string.IsNullOrWhiteSpace(selectedDirectory))
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string destinationPath = folderBrowserDialog.SelectedPath;
                        try
                        {
                            Directory.Move(selectedDirectory, destinationPath);
                            LoadDirectories(Path.GetDirectoryName(selectedDirectory));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error moving directory: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a directory to move.");
            }
        }
    }
}
