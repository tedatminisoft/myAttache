using System;
using myAttache.Portable.Models;
using RestSharp;
using Newtonsoft.Json;

namespace myAttache.Portable.Services
{
    public class UserService
    {
        public User Login(string activationCode, string loginId, string password)
        {
            User retVal = null;
            var client = new RestClient(Globals.EndPoint);
            var request = new RestRequest("api/security/LoginAsync", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("X-MINISOFTAPIKEY", Globals.APIKey);
            var loginBlock = new LoginBlock();
            loginBlock.activationCode = activationCode;
            loginBlock.userName = loginId;
            loginBlock.password = password;
            string loginCredentials = JsonConvert.SerializeObject(loginBlock);
            request.AddJsonBody(loginCredentials);
            var response = client.Post(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                retVal = JsonConvert.DeserializeObject<User>(response.Content);
            return retVal;
        }

    }
}
