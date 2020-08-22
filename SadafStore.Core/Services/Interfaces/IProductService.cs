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
        void EditProductGroups(int productId, List<int> groupId);

        #endregion

        #region Product

        //Before Create 
        ProductForProductListViewModel GetProduct(int pageId = 1, string filterTags = "", string filterProductTitle = "");
        int AddProduct(Product product);
        int CreateProductsForAdmin(CreateProductViewModel product);
        void AddGroupsToProduct(List<int> groupIds, int productId);
        //after Create Product
        Product GetProductById(int productId);
        EditProductViewModel GetProductForEdit(int productId);
        void EditProductFromAdmin(EditProductViewModel editProduct);
        InformationProductViewModel GetProductInformationInAdminPanel(int productId);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);

        #endregion
    }
}
