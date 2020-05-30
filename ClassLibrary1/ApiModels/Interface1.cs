using ClassLibrary1.ApiModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Cache;
using System.Text;

namespace ClassLibrary1.ApiModels
{
   public interface UserJohn
    {
        void GetUsers();
        void PostUsers();
        void GetuserJohn();
        void PostuserJohn();
       
     
        object Get(userJohn req);
    
    }
}

namespace ClassLibrary1.ApiModels
{
    public class userJohn
    {
        public readonly userJohn Client;
        
        public userJohn()
        {
            Client = Client ?? GetUserJohn1();
            Client.BaseUrl = Url(ConfigurationManager.AppSettings.Get("GoRestBaseUrl"));
        }
    
       

        private Url Url(string v)
        {
            throw new NotImplementedException();
        }

        private userJohn GetUserJohn1()
        {
            throw new NotImplementedException();
        }

        public void GetUserJohn(userJohn req)
        {
         userJohn req = new GetRequest("John");
        req.AddHeader("Autorization","Bearer HHCL109yiUfnNcI4oj1YARq08eNr-ZkafTPw");
            var response = Client.Get(req);
        }
        private void AddHeader(string v1, string v2)
        {
            throw new NotImplementedException();
        }

    }
    
}

  

    internal class GetRequest : userJohn
    {
        private string v;

        public GetRequest(string v)
        {
            this.v = v;
        }
    }

namespace ClassLibrary1
{
    class Url
    {
        private string v;

        public Url(string v)
        {
            this.v = v;
        }
    }
}

