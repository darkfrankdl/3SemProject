using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controllers;
using Client.Models;

namespace ForumGUI.Forms
{
    public partial class FormTopics : Form
    {
        ClientTopic _restClient = new ClientTopic("https://localhost:7146/api/APITopic");



        public FormTopics()
        {
            InitializeComponent();
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mForm = new();
            mForm.Show();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPosts fPost = new FormPosts();
            fPost.Show();
        }

        private void btnTopics_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTopics fTopic = new FormTopics();
            fTopic.Show();
        }


        private void getTopicList(object sender, EventArgs e)
        {
            ShowList();              
        }

        private void ShowList()
        {
            if (listBoxTopics.SelectedIndex >= 0)
            {
                getSelectedItem(listBoxTopics.SelectedItem);
            }
            else
            {
                listBoxTopics.Items.Clear();
                List<TopicClient> listTopic = _restClient.Topics().ToList();

                foreach (TopicClient topic in listTopic)
                {
                    listBoxTopics.Items.Add(topic);
                }
            }
        }

        private void getSelectedItem(object selectedItem)
        {
            FormSelctedTopic formSelctedT = new((TopicClient)selectedItem);
            formSelctedT.Show();
            
            listBoxTopics.SelectedItem = 0;

        }


        private void btnShowTopics_Click(object sender, EventArgs e)
        {
            getTopicList(sender, e);

        }


        private void btnCreateTopic_Click(object sender, EventArgs e)
        {
            FormCreateTopic fCreateT = new FormCreateTopic();
            fCreateT.Show();
        }


        private void deleteTopic()
        {
            TopicClient topicToBeDeleted = (TopicClient)listBoxTopics.SelectedItem;

           _restClient.DeleteTopic(topicToBeDeleted);

            listBoxTopics.Items.Clear();


        }

        private void btnEditTopic_Click(object sender, EventArgs e)
        {
            EditTopic();
        }

        private void EditTopic ()
        {
            TopicClient topicToBeEdit = (TopicClient)listBoxTopics.SelectedItem;
            FormEditTopic formEditTopic = new FormEditTopic(topicToBeEdit);
            formEditTopic.ShowDialog();

            listBoxTopics.Items.Clear();
            ShowList();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            deleteTopic();
        }
    }
}
