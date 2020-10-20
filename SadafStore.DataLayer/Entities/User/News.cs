using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.User
{
    public class News
    {
        [Key]
        public int IdForNews { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد!!!")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string EmailForNews { get; set; }

    }
}
