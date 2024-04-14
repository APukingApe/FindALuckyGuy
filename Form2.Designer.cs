namespace FindALuckyGuy
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            nameTextBox = new TextBox();
            button3 = new Button();
            lbNameList = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            previewPictureBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(650, 53);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 53);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(299, 56);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(499, 53);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAdd_Click;
            // 
            // lbNameList
            // 
            lbNameList.FormattingEnabled = true;
            lbNameList.ItemHeight = 25;
            lbNameList.Location = new Point(299, 267);
            lbNameList.Name = "lbNameList";
            lbNameList.Size = new Size(180, 129);
            lbNameList.TabIndex = 5;
            // 
            // previewPictureBox
            // 
            previewPictureBox.Location = new Point(311, 152);
            previewPictureBox.Name = "previewPictureBox";
            previewPictureBox.Size = new Size(150, 75);
            previewPictureBox.TabIndex = 6;
            previewPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button4
            // 
            button4.Location = new Point(499, 171);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 7;
            button4.Text = "ImageButton";
            button4.UseVisualStyleBackColor = true;
            button4.Click += imageButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(previewPictureBox);
            Controls.Add(lbNameList);
            Controls.Add(button3);
            Controls.Add(nameTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            Click += btnAdd_Click;
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox nameTextBox;
        private Button button3;
        private ListBox lbNameList;
        private System.Windows.Forms.Timer timer1;
        private PictureBox previewPictureBox;
        private OpenFileDialog openFileDialog1;
        private Button button4;
    }
}