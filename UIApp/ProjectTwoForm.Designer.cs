namespace UIApp
{
    partial class ProjectTwoForm
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
            label1 = new Label();
            LogicButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 69);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Второй проект";
            // 
            // LogicButton
            // 
            LogicButton.Location = new Point(319, 175);
            LogicButton.Name = "LogicButton";
            LogicButton.Size = new Size(75, 23);
            LogicButton.TabIndex = 1;
            LogicButton.Text = "Старт";
            LogicButton.UseVisualStyleBackColor = true;
            LogicButton.Click += LogicButton_Click;
            // 
            // ProjectTwoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogicButton);
            Controls.Add(label1);
            Name = "ProjectTwoForm";
            Text = "ProjectTwoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LogicButton;
    }
}