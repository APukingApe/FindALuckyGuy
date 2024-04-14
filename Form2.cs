using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FindALuckyGuy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private Dictionary<string, Image> nameToImageMap = new Dictionary<string, Image>();
        public Dictionary<string, Image> NameToImageMap { get; set; }

        private Image image;
        private void Form2_Load_1(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        public void LoadData(Dictionary<string, Image> currentClassData)
        {
            NameToImageMap = currentClassData;
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            lbNameList.Items.Clear();
            foreach (var key in NameToImageMap.Keys)
            {
                lbNameList.Items.Add(key);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name) )
            {
                MessageBox.Show("Please enter a name.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (previewPictureBox.Image == null)
            {
                MessageBox.Show("No image selected. Please select an image first.", "Image Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NameToImageMap.ContainsKey(name))
            {
                MessageBox.Show("This name already has an associated image.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NameToImageMap[name] = previewPictureBox.Image;
                MessageBox.Show("Image and name added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateListBox();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.lbNameList.SelectedItem != null)
            {
                NameToImageMap.Remove(this.lbNameList.SelectedItem.ToString());
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please choose the name to be deleted");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            FileInfo fileInfo = new FileInfo(filePath);

            long sizeInBytes = fileInfo.Length;
            if (sizeInBytes > 5 * 1024 * 1024)
            {
                MessageBox.Show("The file is too large. Please select a file smaller than 2MB.", "File Too Large", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            if (!fileInfo.Extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) &&
                !fileInfo.Extension.Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please select an image file (.jpg, .png).", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog1.Title = "Select an Image";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = Image.FromFile(openFileDialog1.FileName);
                    previewPictureBox.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }
    }
}
