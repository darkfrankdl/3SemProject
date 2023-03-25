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
    public partial class FormCreateComment : Form
    {
 
        private ClientComment _client = new ClientComment("https://localhost:7146/api/APIComment");
        private CommentClient cClient = new();

        private DateTime _postDateTime = new DateTime();
        private string _postUsername = null;

        public FormCreateComment(DateTime postDateTime, String username)
        {
            InitializeComponent();
            this._postDateTime = postDateTime;
            this._postUsername = username;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            cClient.Username = textBoxUsername.Text;
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            cClient.Text = textBoxText.Text;    
        }


        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            string x = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime timeOfCreation = DateTime.Parse(x);
            
            cClient.DateTime = timeOfCreation;
            cClient.PostDateTime = _postDateTime;
            cClient.PostUsername = _postUsername;

            _client.InsertComment(cClient);
            this.Hide();
        }
    }
}
