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
        public int NewPrice { get; set; }
        public int OldPrice { get; set; }
        public string ShortDescription { get; set; }

    }
}
