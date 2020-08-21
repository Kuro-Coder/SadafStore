using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.DTOs.ProductViewModels
{
    public class ShowProductForAdminViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductNumber { get; set; }
        public string ProductFeature { get; set; }
        public bool ProductIsActive { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageName { get; set; }

    }
}
