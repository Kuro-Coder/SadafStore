using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;

namespace SadafStore.Core.DTOs
{
    public class UserPanelViewModel
    {
        public class InformationUserViewModel
        {
            public string Email { get; set; }
            public string AvatarName { get; set; }
            public DateTime RegisterDate { get; set; }
            public int Wallet { get; set; }
            public string UserAddress { get; set; }
            public string TelNumber { get; set; }
        }

        public class NavBarsUserPanelViewModel
        {
            public string UserAvatarInNav { get; set; }
            public string UserNameInNav { get; set; }
            
        }

        public class EditProfileViewModel
        {
            public string UserName { get; set; }
            public string AvatarName { get; set; }
            public string AvatarPhone { get; set; }
            public string AvatarAddress { get; set; }
            public IFormFile AvatarImage { get; set; }
            public string ImageName { get; set; }

        }
    }
}
