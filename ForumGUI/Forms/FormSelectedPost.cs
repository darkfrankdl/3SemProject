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
    public partial class FormSelectedPost : Form
    {
        private String categoryName;
        private PostClient _post;
        public FormSelectedPost(PostClient post, String categoryName)
        {
            InitializeComponent();
            this.categoryName = categoryName;
            this._post = post;
            textBoxPost.Text = _post.Title;
            textBoxTopicSelected.Text = categoryName;
            textBox1.Text = _post.Username;

        }

        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");
        private ClientComment _clientComment = new ClientComment("https://localhost:7146/api/APIComment");

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();

        }

        private void RefreshList()
        {
            if (listBoxPosts.SelectedIndex >= 0)
            {
            }
            else
            {
                listBoxPosts.Items.Clear();
                List<PostClient> listPosts = _client.Posts(categoryName).ToList();

                foreach (PostClient post in listPosts)
                {
                    listBoxPosts.Items.Add(post);
                }
            }
        }

        private void listBoxComments_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxComments.SelectedIndex >= 0)
            {
            }
            else
            {
                listBoxComments.Items.Clear();
                List<CommentClient> listComments = _clientComment.Comments(_post.TimeOfPost, _post.Username).ToList();

                foreach (CommentClient comments in listComments)
                {
                    listBoxComments.Items.Add(comments);
                }
            }
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateComment formCreateComment = new(_post.TimeOfPost, _post.Username);
            formCreateComment.Show();
        }

        private void btnEditPost_Click(object sender, EventArgs e)
        {
            EditPost();
        }

        private void EditPost()
        {
            FormEditPost editFormForPost = new FormEditPost(textBoxPost.Text, _post);
            editFormForPost.ShowDialog();
            RefreshList();

        }

        private void btnShowComments_Click(object sender, EventArgs e)
        {
            listBoxComments_SelectedIndexChanged(sender, e);
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedIndex >= 0)
            {
                CommentClient commentClient = (CommentClient)listBoxComments.SelectedItem;
                _clientComment.DeleteComment(commentClient.DateTime, commentClient.Username);
                listBoxPosts.SelectedIndex = -1;

            }
            listBoxComments.Items.Clear();
            listBoxComments_SelectedIndexChanged(sender, e);
        }
    }
}
