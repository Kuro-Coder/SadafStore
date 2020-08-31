using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.DTOs.ProductViewModels
{
    public class ShowProductListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }
}
