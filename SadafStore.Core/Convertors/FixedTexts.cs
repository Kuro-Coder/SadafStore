using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.Convertors
{
    public class FixedTexts
    {
        public static string FixUserNames(string userName)
        {
            return userName.Trim().ToLower();
        }
        public static string FixEmails(string email)
        {
            return email.Trim().ToLower();
        }
    }
}
