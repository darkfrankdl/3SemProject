using Client.Controllers;
using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ForumGUI.Forms
{
    public partial class FormCreateTopic : Form
    {
        ClientTopic _restClient = new ClientTopic("https://localhost:7146/api/APITopic");
        public FormCreateTopic()
        {
            InitializeComponent();
        }

        private void btnCreateTopic_Click(object sender, EventArgs e)
        {
            TopicClient to = new();
            to.Username = textBoxUsername.Text;
            to.CategoryName = textBoxCategoryName.Text; 
            _restClient.InsertTopic(to);
            this.Hide();
        }

        private void textBoxCategoryName_TextChanged(object sender, EventArgs e)
        {
            TopicClient t = new(); 
            t.CategoryName = textBoxCategoryName.Text;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            TopicClient topic = new TopicClient();
            topic.Username = textBoxUsername.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
