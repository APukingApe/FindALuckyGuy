using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FindALuckyGuy
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Image> nameToImageMap = new Dictionary<string, Image>();
        private Dictionary<string, Dictionary<string, Image>> classToNameImageMap = new Dictionary<string, Dictionary<string, Image>>();

        public Form1()
        {

            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            foreach (var key in classToNameImageMap.Keys)
            {
                classComboBox.Items.Add(key);
            }
            if (classComboBox.Items.Count > 0)
                classComboBox.SelectedIndex = 0;
        }

        private void UpdateComboBox()
        {
            classComboBox.Items.Clear();
            LoadClasses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Owner = this;
            form.LoadData(nameToImageMap);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRollCall_Click(object sender, EventArgs e)
        {
            if (lblName.Text == "Start")
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nameToImageMap.Count > 0)
            {
                List<string> keys = new List<string>(nameToImageMap.Keys);
                int index = random.Next(keys.Count);
                string selectedName = keys[index];

                lblName.Text = selectedName;
                pictureBox1.Image = nameToImageMap[selectedName];
            }
            else
            {
                lblName.Text = "No entries in dictionary";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            lblName.Text = "Start";
            pictureBox1.Image = null;
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classComboBox.SelectedIndex != -1)
            {
                string selectedClass = classComboBox.SelectedItem.ToString();
                UpdateClassData(selectedClass);
            }
        }

        private void UpdateClassData(string className)
        {
            if (classToNameImageMap.ContainsKey(className))
            {
                nameToImageMap = classToNameImageMap[className];
            }
            else
            {
                nameToImageMap = new Dictionary<string, Image>();
                classToNameImageMap[className] = nameToImageMap;
            }
        }

        private void editClassButton_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Owner = this;
            form.LoadData(classToNameImageMap);
            form.ShowDialog();
        }

        private void updateClassButton_Click(object sender, EventArgs e)
        {
            LoadClasses();
 
        }
    }
}
