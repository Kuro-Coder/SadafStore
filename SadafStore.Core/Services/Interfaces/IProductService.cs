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

        List<Group> GetAllGroups();
        List<SelectListItem> GetGroupForManageProduct();
        List<SelectListItem> GetSubGroupForManageProduct(int groupId);
        void EditProductGroups(int productId, List<int> groupId);

        #endregion

        #region Product(Admin)

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
        ProductForProductListViewModel GetDeleteProducts(int pageId = 1, string filterTags = "", string filterProductTitle = "");

        #endregion

        #region Product Showing

        Tuple<List<ShowProductListViewModel>, int> GetProductsList(int pageId = 1, string filter = "", string orderBy = "", int take = 0, List<int> selectedGroups = null);

        Product GetProductForShow(int productId);

        #endregion

        #region Comments

        void AddComment(ProductComment comment);
        Tuple<List<ProductComment>,int> GetProductComment(int productId, int pageId=1);

        #endregion

        #region Popular Product

        List<ShowProductListViewModel> GetPopularProduct();

        #endregion
    }
}
