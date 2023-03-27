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
    public partial class FormEditTopic : Form
    {
        private TopicClient topic = null;
        ClientTopic _restClient = new ClientTopic("https://localhost:7146/api/APITopic");
        public FormEditTopic(TopicClient topic)
        {
            InitializeComponent();
            this.topic = topic;
            txtBoxSelectedTopic.Text = topic.CategoryName;
        }

        private void btnEditTopicOK_Click(object sender, EventArgs e)
        {
            OkClicked();
        }

        private void OkClicked()
        {
            string newCategoryName = txtBoxCategoryName.Text;

            topic.NewCategoryname = newCategoryName;
            if(newCategoryName!=null)
            {
                _restClient.UpdateTopic(topic);
            }
            this.Close();
        }
    }
}
