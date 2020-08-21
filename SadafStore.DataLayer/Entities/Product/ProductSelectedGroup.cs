using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SadafStore.DataLayer.Entities.Product
{
    public class ProductSelectedGroup
    {
        public ProductSelectedGroup()
        {
            
        }

        [Key]
        public int PSG_Id { get; set; }

        public int ProductId { get; set; }
        
        public int GroupId { get; set; }

        #region Relations

        public Product Product { get; set; }
        public ProductGroup ProductGroup { get; set; }

        #endregion

    }
}
