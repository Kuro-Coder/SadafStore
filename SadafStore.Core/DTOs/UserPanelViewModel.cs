using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.DTOs
{
    public class UserPanelViewModel
    {
        public class InformationUserViewModel
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public DateTime RegisterDate { get; set; }
            public int Wallet { get; set; }
            public string UserAddress { get; set; }
            public string TelNumber { get; set; }
        }
    }
}
