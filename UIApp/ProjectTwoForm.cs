using SignsCreatorWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using UIApp.Models;

namespace UIApp
{
    public partial class ProjectTwoForm : Form
    {
        public ProjectTwoForm()
        {
            InitializeComponent();
        }

        private void LogicButton_Click(object sender, EventArgs e)
        {
            SecondProjectData secondProjectData = new SecondProjectData { Name = "Testname", Type="TestType" };

            Command command = new Command { Type = "SecondProject", Data = JsonSerializer.Serialize(secondProjectData) };

            HttpClient httpClient = new HttpClient();

            var Query = httpClient.PostAsync("https://localhost:7197/RunTask", JsonContent.Create(command)).Result;
        }
    }
}
