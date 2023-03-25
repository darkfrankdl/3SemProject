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
    public partial class FormEditPost : Form
    {
        private string postTitle;
        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");
        private PostClient _post;
        public FormEditPost(string postTitle, PostClient post)
        {
            InitializeComponent();
            this.postTitle = postTitle;
            this._post = post;
        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            CloseThisForm();
            
        }

        private void CloseThisForm()
        {
            this.Close();
        }

        private void btnEditPostOK_Click(object sender, EventArgs e)
        {
            OkClicked();
        }

        private void OkClicked()
        {
            _post.Text = txtBoxPostText.Text;
            _client.UpdatePost(_post);
            CloseThisForm();
        }
    }
}
