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
    public partial class FormCreateProfile : Form
    {
        private ClientProfile _client = new ClientProfile("https://localhost:7146/api/APIProfile");

        public FormCreateProfile()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            PersonClient p = new PersonClient();
            p.Username = textBoxUsername.Text;
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
           PersonClient pc = new PersonClient();
            pc.Usertype = textBoxUsertype.Text;
            pc.Password = textBoxPassword.Text;
            pc.Username = textBoxUsername.Text;
            pc.Points = 0;
            _client.InsertProfile(pc);
            this.Hide();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            PersonClient p = new PersonClient();
            p.Password = textBoxPassword.Text;
        }

        private void textBoxPoints_TextChanged(object sender, EventArgs e)
        {
            PersonClient p = new PersonClient();
        }

        private void textBoxUsertype_TextChanged(object sender, EventArgs e)
        {
            PersonClient p = new PersonClient();
            p.Usertype = textBoxUsertype.Text;
        }
    }
}
