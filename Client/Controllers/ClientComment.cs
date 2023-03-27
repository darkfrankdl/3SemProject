using RestSharp;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Client.Controllers
{
    public class ClientComment : IClientComment
    {
        private RestClient _client;

        public ClientComment(string restUrl)
        {
            _client = new RestClient(restUrl);
        }

        public void DeleteComment(DateTime time, string username)
        {
            string timeCorrectFormat = ConvertDateTimeToStringInUSFormat(time);
            //sends a DELETE request to "api/apicomments/{id}"
            //and returns the returnvalue
            var request = new RestRequest("", Method.Delete);
            request.AddQueryParameter("dateTimeComment", timeCorrectFormat);
            request.AddQueryParameter("username", username);
            _client.Delete(request);
        }

        public IEnumerable<CommentClient> Comments(DateTime time, string username)
        {
            //sends a GET request to "api/apicomments"
            RestRequest request = new RestRequest($"{time}/{username}");

            return _client.Get<IEnumerable<CommentClient>>(request);
        }

        public void InsertComment(CommentClient comment)
        {
            //sends a POST request to "api/apicomments"
            //with the Comment as a JSON object in body
            //and returns the primary of the inserted comment

            var request = new RestRequest("", Method.Post);
            request.AddQueryParameter("Text", comment.Text);
            request.AddQueryParameter("Username", comment.Username);
            request.AddQueryParameter("DateTime", comment.DateTime);
            request.AddQueryParameter("PostDateTime", comment.PostDateTime);
            request.AddQueryParameter("PostUsername", comment.PostUsername);
            request.AddBody(comment);
            _client.Post(request);
        }

        public void UpdateComment(CommentClient comment)
        {
            //sends a PUT request to "api/apicomments"
            //with the Comment as a JSON object in body
            //and returns whether the comment was found on the server
            var request = new RestRequest("", Method.Put);
            request.AddQueryParameter("Text", comment.Text);
            request.AddQueryParameter("Username", comment.Username);
            request.AddQueryParameter("DateTime", comment.DateTime);
            request.AddQueryParameter("PostDateTime", comment.PostDateTime);
            request.AddQueryParameter("PostUsername", comment.PostUsername);
            request.AddBody(comment);
            _client.Put(request);
        }

        private string ConvertDateTimeToStringInUSFormat(DateTime time)
        {
            string day = null;
            string month = null;
            string hour = null;
            string minute = null;
            string second = null;
            string year = time.Year.ToString();

            if (time.Day.ToString().Length == 1)
            {
                day = "0" + time.Day;
            }
            else
            {
                day = time.Day.ToString();
            }


            if (time.Month.ToString().Length == 1)
            {
                month = "0" + time.Month;
            }
            else
            {
                month = time.Month.ToString();
            }


            if (time.Hour.ToString().Length == 1)
            {
                hour = "0" + time.Hour;
            }
            else
            {
                hour = time.Hour.ToString();
            }

            if (time.Minute.ToString().Length == 1)
            {
                minute = "0" + time.Minute;
            }
            else
            {
                minute = time.Minute.ToString();
            }

            if (time.Second.ToString().Length == 1)
            {
                second = "0" + time.Second;
            }
            else
            {
                second = time.Second.ToString();
            }

            string date = $"{year}-{month}-{day} {hour}:{minute}:{second}";

            return date;
        }

    }
}
