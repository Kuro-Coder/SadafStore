using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.DTOs.ProductViewModels
{
    public class ShowProductForAdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public string Feature { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

    }
}
