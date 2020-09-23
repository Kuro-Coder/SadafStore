using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SadafStore.DataLayer.Entities.Product
{
    public class Group
    {
        public Group()
        {
            
        }

        [Key]
        public int GroupId { get; set; }

        [Display(Name = "نام گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید!!!")]
        [MaxLength(200, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد!!!")]
        public string GroupTitle { get; set; }

        [Display(Name = "حذف شده")]
        public bool IsDelete { get; set; }

        [Display(Name = "عضوگروه")]
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public List<Group> ProductGroups { get; set; }


        #region Relations

        public virtual List<ProductSelectedGroup> ProductSelectedGroups { get; set; }

        #endregion

    }
}
