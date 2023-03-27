using Client.Controllers;
using Client.Models;
using RestSharp;
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
    public partial class FormEditProfile : Form
    {
        private ClientProfile _client = new ClientProfile("https://localhost:7146/api/APIProfile");
        private PersonClient profile = null;
        public FormEditProfile(PersonClient profile)
        {
            InitializeComponent();
            this.profile = profile;
            txtBoxSelectedProfile.Text = profile.Username;
        }

        private void OkClicked()
        {
            String password = txtBoxPassword.Text;
            profile.Password = password;
            if(profile != null)
            {
                _client.UpdateProfile(profile);
            }
            this.Close();
        }

        private void btnEditTopicOK_Click(object sender, EventArgs e)
        {
            OkClicked();
        }
    }
}
