using RestSharp;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Client.Controllers
{
    public class ClientPost
    {
        private RestClient _client;

        public ClientPost(string restUrl)
        {
            _client = new RestClient (restUrl);
        }

        public void DeletePost(PostClient post)
        {
            //sends a DELETE request to "api/apiposts/{id}"
            //and returns the returnvalue
            string date = ConvertDateTimeToStringInUSFormat(post.TimeOfPost);
            var request = new RestRequest($"{date}/{post.Username}",Method.Delete);
            _client.Delete(request);
        }

        public IEnumerable<PostClient> Posts(string categoryName)
        {
            //sends a GET request to "api/apiposts"
            return _client.Get<IEnumerable<PostClient>>(new RestRequest($"{categoryName}"));
        }

        public IEnumerable<PostClient> AllPosts()
        {
            //sends a GET request to "api/apiposts"
            return _client.Get<IEnumerable<PostClient>>(new RestRequest($""));
        }

        public PostClient GetPost(PostClient post)
        {
            string date = ConvertDateTimeToStringInUSFormat(post.TimeOfPost);
            post.TimeOfPost = DateTime.Parse(date);
            var request = new RestRequest($"{date}/{post.Username}");
            return _client.Get<PostClient>(request);
        }

        public void InsertPost (PostClient post)
        {
            //sends a POST request to "api/apiposts"
            //with the Post as a JSON object in body
            //and returns the primary of the inserted post
            var request = new RestRequest($"{post.TimeOfPost}/{post.Username}", Method.Post);
            request.AddBody(post);
            _client.Post(request);
        }

        public void UpdatePost(PostClient post)
        {
            //sends a PUT request to "api/apiposts"
            //with the Post as a JSON object in body
            //and returns whether the post was found on the server
            var request = new RestRequest($"{post.TimeOfPost}/{post.Username}", Method.Put);
            request.AddBody(post);
            _client.Put(request);
        }

        private string ConvertDateTimeToStringInUSFormat (DateTime time)
        {
            string day = null;
            string month = null;
            string hour = null;
            string minute = null;
            string second = null;
            string year = time.Year.ToString();

            if (time.Day.ToString().Length ==1)
            {
                day = "0" + time.Day;
            }
            else
            {
                day = time.Day.ToString();
            }

            
            if (time.Month.ToString().Length ==1)
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
