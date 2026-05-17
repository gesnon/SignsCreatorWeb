namespace UIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Project1_Button_Click(object sender, EventArgs e)
        {
            ProjectOneForm projectOneForm = new ProjectOneForm();
            projectOneForm.Activate();
            projectOneForm.Visible = true;
        }

        private void Project2_Button_Click(object sender, EventArgs e)
        {
            ProjectTwoForm projectTwoForm = new ProjectTwoForm();
            projectTwoForm.Activate();
            projectTwoForm.Visible = true;
        }
    }
}
