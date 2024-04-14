namespace FindALuckyGuy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            nameButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblName = new Label();
            resetButton = new Button();
            pictureBox1 = new PictureBox();
            classComboBox = new ComboBox();
            editClassButton = new Button();
            updateClassButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(678, 371);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Manage List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(107, 378);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nameButton
            // 
            nameButton.Location = new Point(317, 291);
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(203, 32);
            nameButton.TabIndex = 2;
            nameButton.Text = "Guess who's lucky";
            nameButton.UseVisualStyleBackColor = true;
            nameButton.Click += buttonRollCall_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(396, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 25);
            lblName.TabIndex = 3;
            lblName.Text = "Start";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(360, 357);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(112, 34);
            resetButton.TabIndex = 4;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(299, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 134);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // classComboBox
            // 
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(588, 213);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(182, 33);
            classComboBox.TabIndex = 6;
            classComboBox.SelectedIndexChanged += classComboBox_SelectedIndexChanged;
            // 
            // editClassButton
            // 
            editClassButton.Location = new Point(588, 262);
            editClassButton.Name = "editClassButton";
            editClassButton.Size = new Size(112, 34);
            editClassButton.TabIndex = 7;
            editClassButton.Text = "Edit Classes";
            editClassButton.UseVisualStyleBackColor = true;
            editClassButton.Click += editClassButton_Click;
            // 
            // updateClassButton
            // 
            updateClassButton.Location = new Point(719, 262);
            updateClassButton.Name = "updateClassButton";
            updateClassButton.Size = new Size(112, 34);
            updateClassButton.TabIndex = 8;
            updateClassButton.Text = "button3";
            updateClassButton.UseVisualStyleBackColor = true;
            updateClassButton.Click += updateClassButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 582);
            Controls.Add(updateClassButton);
            Controls.Add(editClassButton);
            Controls.Add(classComboBox);
            Controls.Add(pictureBox1);
            Controls.Add(resetButton);
            Controls.Add(lblName);
            Controls.Add(nameButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "btnName";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button nameButton;
        private System.Windows.Forms.Timer timer1;
        private Label lblName;
        private Button resetButton;
        private PictureBox pictureBox1;
        private ComboBox classComboBox;
        private Button editClassButton;
        private Button updateClassButton;
    }
}