using FlowCoach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FlowCoach.Services
{
    public abstract class ApiBase<T> where T : class
    {
        protected Uri baseUri;
        protected ApiBase() //Note this will only work if the correct part of the name is only two "." away
        {
            string generic = typeof(T).ToString();
            var uriPath = generic.Split('.');
            baseUri = new Uri($"https://localhost:7228/api/{uriPath[uriPath.Length - 1]}/");
        }

        protected async Task<HttpResponseMessage> ExecuteHttp(string url, string method, T? parameter = null )
        {
            try
            {
                UriBuilder uriBuilder = new(baseUri + url);

                if (method == "GET" && parameter != null)
                {
                    uriBuilder.Query = $"id={parameter}";
                }

                HttpClientHandler handler = new HttpClientHandler()
                {
                    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
                };
                using HttpClient client = new(handler);
                HttpResponseMessage response = null; ;
                switch (method)
                {
                    case "GET":
                         response = await client.GetAsync(uriBuilder.Uri);
                        break;
                    case "POST":
                        response = await client.PostAsJsonAsync(uriBuilder.Uri, parameter);
                        break;
                    case "PUT":
                        response = await client.PutAsJsonAsync(uriBuilder.Uri, parameter);
                        break;
                    case "DELETE":
                        uriBuilder.Query = $"id={parameter}";
                        response = await client.DeleteAsync(uriBuilder.Uri);
                        break;
                    default:
                        throw new Exception("Invalid Method");

                }
                

                if (!response.IsSuccessStatusCode)
                {
                    //List<Entities.Task> tasks = new List<Entities.Task>();
                    //tasks = await response.Content.ReadFromJsonAsync<List<Entities.Task>>();
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
                return response;
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                var response = await ExecuteHttp($"GetAll", "GET");
                if (response.IsSuccessStatusCode)
                {

                    var result = await response.Content.ReadFromJsonAsync<IEnumerable<T>>();

                    return result;
                }
                throw new Exception("Null Reference has occuried");
            }
            catch
            {
                throw;
            }
        }

        public virtual async Task<T> GetBy(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task Post(T Entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task Put(T Entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task Delete(T Entity)
        {
            throw new NotImplementedException();
        }

    }
}
