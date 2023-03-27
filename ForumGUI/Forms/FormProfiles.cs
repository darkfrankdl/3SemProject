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
    public partial class FormProfiles : Form
    {
        private ClientProfile _client = new ClientProfile("https://localhost:7146/api/APIProfile");
        public FormProfiles()
        {
            InitializeComponent();
        }

        private void ListOfProfiles(object sender, EventArgs e)
        {
            if (listBoxProfiles.SelectedIndex >= 0)
            {
            }
            else
            {
                listBoxProfiles.Items.Clear();
                List<PersonClient> listProfiles = _client.Profiles().ToList();

                foreach (PersonClient person in listProfiles)
                {
                    listBoxProfiles.Items.Add(person);
                }
            }
        }

        private void getSelectedItem(object selectedItem)
        {


            listBoxProfiles.SelectedItem = 0;

        }

        private void btn_ShowProfiles(object sender, EventArgs e)
        {
            ListOfProfiles(sender, e);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreateProfile fCreatePro = new();
            fCreatePro.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PersonClient profileToBeEdit = (PersonClient)listBoxProfiles.SelectedItem;
            FormEditProfile fEditPro = new(profileToBeEdit);
            fEditPro.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProfile();
        }


        private void deleteProfile()
        {
            PersonClient profileToBeDeleted = (PersonClient)listBoxProfiles.SelectedItem;
            _client.DeleteProfile(profileToBeDeleted);

            listBoxProfiles.Items.Clear();

        }


    }
}
