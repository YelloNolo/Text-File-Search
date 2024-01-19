using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class FileSearch : Form
    {
        private string selectedFilePath = string.Empty;
        public FileSearch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputForm_TextChanged(object sender, EventArgs e)
        {

        }

        // Select file button
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    // Display the selected file path in textbox
                    SelectedFileDisplay.Text = selectedFilePath;
                }
            }
        }

        // Search Button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchBar.Text;
            Search();
        }

        // Allow enter key to search in searchBar
        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search();
            }
        }

        private void Search()
        {
            string searchText = searchBar.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Please enter text to search.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedFilePath))
            {
                MessageBox.Show("Please select a text file.");
                return;
            }

            try
            {
                // Read the selected text file line by line
                string[] lines = File.ReadAllLines(selectedFilePath);

                // Clear the current output
                outputForm.Clear();

                foreach (string line in lines)
                {
                    if (line.Contains(searchText))
                    {
                        // Append lines containing the search text to the output form
                        outputForm.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectedFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectedFileDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            SelectedFileDisplay.SelectAll();
        }
    }
}
