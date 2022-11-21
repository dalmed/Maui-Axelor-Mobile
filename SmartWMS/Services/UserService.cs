using Microsoft.Extensions.Logging;
using RestSharp;
using SmartWMS.DTO.Models;
using SmartWMS.DTO.VirtualModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWMS.Services
{
    public class UserService : IUserService
    {
        private IRestClientService RestService => DependencyService.Get<IRestClientService>();
        public UserService()
        {

        }

        public async Task<User> GetUserAsync(string code, CancellationToken cancellationToken = default)
        {
            try
            {
                /*
                 {
                   "offset": 0,
                   "limit": 10,
                   "fields": ["fullName", "email"],
                   "sortBy": ["fullName", "-createdOn"],
                   "data": {
                     "_domain": "self.email like :email",
                     "_domainContext": {
                       "email": "%gmail.com"
                     },
                     "_archived": true
                   }
                 }
                 */

                var rq = new SearchRequest
                {
                    Offset = 0,
                    Limit = 1,
                    SearchData = new SearchData
                    {
                        Domain = "self.code like :code",
                        DomainContext = new Dictionary<string, string>() { { "code", code } }
                    }
                };

                var userData = await RestService.RestServiceSearchAsync<User>(Constants.Models.Auth.User, rq);

                if (userData != null && userData.Total > 0)
                {
                    return userData.Data.FirstOrDefault();
                }
                return null;
            }
            catch (Exception e)
            {
                Log.Error(e);
                throw;
            }
        }

    }
}
