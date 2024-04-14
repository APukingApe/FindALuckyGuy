using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindALuckyGuy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Dictionary<string, Dictionary<string, Image>> ClassToNameImageMap { get; set; }

        public void LoadData(Dictionary<string, Dictionary<string, Image>> currentClass)
        {
            ClassToNameImageMap = currentClass;
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            classNameList.Items.Clear();
            foreach (var key in ClassToNameImageMap.Keys)
            {
                classNameList.Items.Add(key);
            }
        }

        private void deleteClassButton_Click(object sender, EventArgs e)
        {
            if (this.classNameList.SelectedItem != null)
            {
                ClassToNameImageMap.Remove(this.classNameList.SelectedItem.ToString());
                UpdateListBox();
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            string name = classNameBox.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please enter a valid name.", "Name Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ClassToNameImageMap.ContainsKey(name))
            {
                MessageBox.Show("Please enter a different class name.", "Name Repeated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ClassToNameImageMap[name] = new Dictionary<string, Image>();
                MessageBox.Show("Class name added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateListBox();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).Show();
            this.Hide();
        }
    }
}
