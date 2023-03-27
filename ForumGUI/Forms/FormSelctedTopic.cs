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
    public partial class FormSelctedTopic : Form
    {
        ClientTopic _restClient = new ClientTopic("https://localhost:7146/api/APITopic");
        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");

        public FormSelctedTopic(TopicClient topic)
        {
            InitializeComponent();
            textBox1_TextChanged(topic);
            textBox2_TextChanged(topic);
            textBox3_TextChanged(topic);
        }

          private void textBox1_TextChanged(object topic)
          {
            
            TopicClient t = (TopicClient)topic;
            textBoxTopicSelected.Text = t.CategoryName;
          }

        private void textBox2_TextChanged(object topic)
        {
            TopicClient t = (TopicClient)topic;
            textBoxTopic.Text = t.CategoryName;
        }

        private void textBox3_TextChanged(object topic)
        {
            TopicClient t = (TopicClient)topic;
            textBoxCreatedByUsername.Text = t.Username;
        }

        private void textBoxTopic_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll();

        }

        private void ShowAll()
        {
            if (listBoxPosts.SelectedIndex >= 0)
            {
                getSelectedItem(listBoxPosts.SelectedItem);
            }
            else
            {
                listBoxPosts.Items.Clear();
                List<PostClient> listPost = _client.Posts(textBoxTopicSelected.Text).ToList();

                foreach (PostClient post in listPost)
                {
                    listBoxPosts.Items.Add(post);
                }
                listBoxPosts.Show();
            }
        }

        private void getSelectedItem(object selectedItem)
        {
            FormSelectedPost formSelectedP = new((PostClient) selectedItem, textBoxTopicSelected.Text);
            formSelectedP.Show();
            listBoxPosts.SelectedItem = 0;

        }

        private void btnShowPosts_Click(object sender, EventArgs e)
        {
            listBoxPosts.Items.Clear();
            listBoxPosts_SelectedIndexChanged(sender, e);
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {

            string categoryName = textBoxTopicSelected.Text;
            FormCreatePost fCreateP = new(categoryName);
            fCreateP.Show();
        }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedIndex >= 0)
            {
                PostClient post = (PostClient)listBoxPosts.SelectedItem;
                _client.DeletePost(post);
                listBoxPosts.SelectedIndex = -1;

            }
            ShowAll();
        }
    }
        
  }

