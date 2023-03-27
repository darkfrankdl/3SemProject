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
    public partial class FormPosts : Form
    {
        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");
        public FormPosts()
        {
            InitializeComponent();
        }

        private void btnTopics_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTopics fTopic = new FormTopics();
            fTopic.Show();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPosts fPost = new FormPosts();
            fPost.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mForm = new();
            mForm.Show();
        }

        private void getListBoxPosts(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            if (listBoxPosts.SelectedIndex >= 0)
            {
            }
            else
            {
                List<PostClient> listPost = _client.AllPosts().ToList();

                foreach (PostClient post in listPost)
                {
                    listBoxPosts.Items.Add(post);
                }
                listBoxPosts.Show();
            }
        }

        private void btnShowTopics_Click(object sender, EventArgs e)
        {
            getListBoxPosts(sender, e);
            btnShowTopics.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
