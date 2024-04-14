namespace FindALuckyGuy
{
    partial class Form3
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
            classNameList = new ListBox();
            returnButton = new Button();
            addClassButton = new Button();
            deleteClassButton = new Button();
            classNameBox = new TextBox();
            SuspendLayout();
            // 
            // classNameList
            // 
            classNameList.FormattingEnabled = true;
            classNameList.ItemHeight = 25;
            classNameList.Location = new Point(243, 123);
            classNameList.Name = "classNameList";
            classNameList.Size = new Size(180, 129);
            classNameList.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(63, 44);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(112, 34);
            returnButton.TabIndex = 1;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // addClassButton
            // 
            addClassButton.Location = new Point(479, 42);
            addClassButton.Name = "addClassButton";
            addClassButton.Size = new Size(112, 34);
            addClassButton.TabIndex = 2;
            addClassButton.Text = "button2";
            addClassButton.UseVisualStyleBackColor = true;
            addClassButton.Click += addClassButton_Click;
            // 
            // deleteClassButton
            // 
            deleteClassButton.Location = new Point(479, 218);
            deleteClassButton.Name = "deleteClassButton";
            deleteClassButton.Size = new Size(112, 34);
            deleteClassButton.TabIndex = 3;
            deleteClassButton.Text = "button3";
            deleteClassButton.UseVisualStyleBackColor = true;
            deleteClassButton.Click += deleteClassButton_Click;
            // 
            // classNameBox
            // 
            classNameBox.Location = new Point(262, 44);
            classNameBox.Name = "classNameBox";
            classNameBox.Size = new Size(150, 31);
            classNameBox.TabIndex = 4;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(classNameBox);
            Controls.Add(deleteClassButton);
            Controls.Add(addClassButton);
            Controls.Add(returnButton);
            Controls.Add(classNameList);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox classNameList;
        private Button returnButton;
        private Button addClassButton;
        private Button deleteClassButton;
        private TextBox classNameBox;
    }
}