using System.Collections.Generic;

namespace Login.tn.Admin.Api.Dtos.Users
{
    public class UserProvidersApiDto<TUserDtoKey>
    {
        public UserProvidersApiDto()
        {
            Providers = new List<UserProviderApiDto<TUserDtoKey>>();
        }

        public List<UserProviderApiDto<TUserDtoKey>> Providers { get; set; }
    }
}





