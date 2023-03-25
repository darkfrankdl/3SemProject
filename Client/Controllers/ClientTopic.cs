using RestSharp;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Client.Controllers
{
    public class ClientTopic
    {
        private RestClient _client;

        public ClientTopic (string restUrl)
        {
            _client = new RestClient (restUrl);
        }

        public void DeleteTopic(TopicClient topic)
        {
            //sends a DELETE request to "api/apitopics/{id}"
            //and returns the returnvalue
            var request = new RestRequest($"{topic.CategoryName}", Method.Delete);
            _client.Delete(request);
        }

        public IEnumerable<TopicClient> Topics()
        {
            //sends a GET request to "api/apitopics"
            return _client.Get<IEnumerable<TopicClient>>(new RestRequest());
        }

        public void InsertTopic(TopicClient topic)
        {
            //sends a POST request to "api/apitopics"
            //with the Topic as a JSON object in body
            //and returns the primary of the inserted topic
            var request = new RestRequest($"{topic.CategoryName}", Method.Post);
            request.AddBody(topic);
            _client.Post(request);
        }

        public bool UpdateTopic(TopicClient topic)
        {
            //sends a PUT request to "api/apitopics"
            //with the Topic as a JSON object in body
            //and returns whether the topic was found on the server
            var request = new RestRequest($"{topic.NewCategoryname}", Method.Put);
            request.AddBody(topic);
            return _client.Put<bool>(request);
        }

    }
}
