using Client.Controllers;
using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ForumGUI.Forms
{
    public partial class FormCreatePost : Form
    {
        private string _categoryName = null;
        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");

        public FormCreatePost(string categoryName)
        {
            InitializeComponent();
            this._categoryName = categoryName;

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            PostClient p2 = new(); 
            p2.Title = textBoxTitle.Text;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            PostClient p1 = new();
            p1.Username = textBoxUsername.Text;
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            PostClient p3 = new();
            p3.Text = textBoxText.Text;
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {


            string x = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
              DateTime timeOfCreation = DateTime.Parse(x);

            PostClient p = new();
            p.TopicCategoryName = _categoryName;
            p.TimeOfPost = timeOfCreation;
            p.Title = textBoxTitle.Text;
            p.Text = textBoxText.Text;
            p.Username = textBoxUsername.Text;
            p.Points = 1;
            _client.InsertPost(p);
            this.Hide();
        }
    }
}
