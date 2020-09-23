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

        public int GroupId { get; set; }

        public int ProductId { get; set; }

        #region Relations

        public virtual Product Product { get; set; }
        public virtual Group ProductGroup { get; set; }

        #endregion

    }
}
