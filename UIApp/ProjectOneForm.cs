using SignsCreatorWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using UIApp.Models;

namespace UIApp
{
    public partial class ProjectOneForm : Form
    {
        public ProjectOneForm()
        {
            InitializeComponent();
        }

        private void LogicButton_Click(object sender, EventArgs e)
        {

            FirstProjectData firstProjectData = new FirstProjectData { Name = "Testname", Number = 1 };

            Command command = new Command { Type = "FirstProject", Data = JsonSerializer.Serialize(firstProjectData) };


            HttpClient httpClient = new HttpClient();

            var Query = httpClient.PostAsync("https://localhost:7197/RunTask", JsonContent.Create(command)).Result;

        }
    }



}
