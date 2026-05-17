namespace UIApp
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
            Project1_Button = new Button();
            Project2_Button = new Button();
            SuspendLayout();
            // 
            // Project1_Button
            // 
            Project1_Button.Location = new Point(376, 123);
            Project1_Button.Name = "Project1_Button";
            Project1_Button.Size = new Size(75, 23);
            Project1_Button.TabIndex = 0;
            Project1_Button.Text = "Проект 1";
            Project1_Button.UseVisualStyleBackColor = true;
            Project1_Button.Click += Project1_Button_Click;
            // 
            // Project2_Button
            // 
            Project2_Button.Location = new Point(376, 194);
            Project2_Button.Name = "Project2_Button";
            Project2_Button.Size = new Size(75, 23);
            Project2_Button.TabIndex = 1;
            Project2_Button.Text = "Проект 2";
            Project2_Button.UseVisualStyleBackColor = true;
            Project2_Button.Click += Project2_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Project2_Button);
            Controls.Add(Project1_Button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Project1_Button;
        private Button Project2_Button;
    }
}
