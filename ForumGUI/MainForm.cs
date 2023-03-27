using Client.Controllers;
using Client.Models;
using ForumGUI.Forms;


namespace ForumGUI
{
    public partial class MainForm : Form
    {
        ClientTopic _restClient = new ClientTopic("https://localhost:7146/api/APITopic");
        private ClientPost _client = new ClientPost("https://localhost:7146/api/APIPost");
        public MainForm()
        {
            InitializeComponent();
        }


        private void listPostsHome(object sender, EventArgs e)
        {

            List<PostClient> listPost = _client.AllPosts().ToList();

            foreach (PostClient post in listPost)
            {
                listBoxOfPostHome.Items.Add(post);
            }
            listBoxOfPostHome.Show();
        }

        private void listTopicsHome(object sender, EventArgs e)
        {
            List<TopicClient> listTopic = _restClient.Topics().ToList(); 

            foreach (TopicClient topic in listTopic)
            {
                listBoxOfTopicsHome.Items.Add(topic);
            }
            listBoxOfTopicsHome.Show();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mForm = new();
            mForm.Show();
        }



        private void btnShowTopics_Click(object sender, EventArgs e)
        {
            listTopicsHome(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listPostsHome(sender, e);
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfiles fProfiles = new FormProfiles();
            fProfiles.Show();
        }
    }
}