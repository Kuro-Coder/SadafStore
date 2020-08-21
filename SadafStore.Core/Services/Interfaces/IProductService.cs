using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SadafStore.Core.DTOs.ProductViewModels;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IProductService
    {
        #region Groups

        List<ProductGroup> GetAllGroups();
        List<SelectListItem> GetGroupForManageProduct();
        List<SelectListItem> GetSubGroupForManageProduct(int groupId);

        #endregion

        #region Product

        int AddProduct(Product product);
        int CreateProductsForAdmin(CreateProductViewModel product);
        void AddGroupsToProduct(List<int> groupIds, int productId);

        #endregion
    }
}
