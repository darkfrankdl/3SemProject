using RestSharp;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Client.Controllers
{
    public class ClientProfile
    {
        private RestClient _client;

        public ClientProfile(string restUrl)
        {
            _client = new RestClient (restUrl);
        }

        public void DeleteProfile(PersonClient person)
        {
            //sends a DELETE request to "api/apiprofile/{id}"
            //and returns the returnvalue
            var request = new RestRequest($"{person.Username}",Method.Delete);
            _client.Delete(request);
        }

        public IEnumerable<PersonClient> Profiles()
        {
            //sends a GET request to "api/apiprofile"
            return _client.Get<IEnumerable<PersonClient>>(new RestRequest());
        }

        public void InsertProfile (PersonClient person)
        {
            //sends a POST request to "api/apiprofile"
            //with the Person as a JSON object in body
            //and returns the primary of the inserted person

            var request = new RestRequest($"{person.Username}", Method.Post);
            request.AddBody(person);
            _client.Post(request);
        }

        public void UpdateProfile(PersonClient person)
        {
            //sends a PUT request to "api/apiprofile"
            //with the Person as a JSON object in body
            //and returns whether the person was found on the server
            var request = new RestRequest($"{person.Username}", Method.Put);
            request.AddBody(person);
            _client.Put(request);
        }

    }
}
