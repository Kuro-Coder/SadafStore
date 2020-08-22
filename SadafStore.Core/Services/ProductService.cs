using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using SadafStore.Core.CodeGenerator;
using SadafStore.Core.DTOs.ProductViewModels;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Context;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.Core.Services
{
    public class ProductService: IProductService
    {
        private SadafStoreContext _context;

        public ProductService(SadafStoreContext context)
        {
            _context = context;
        }

        public ProductForProductListViewModel GetProduct(int pageId = 1, string filterTags = "", string filterProductTitle = "")
        {
            IQueryable<Product> result = _context.Products;
            if (!string.IsNullOrEmpty(filterProductTitle))
            {
                result = result.Where(u => u.ProductTitle.Contains(filterProductTitle));
            }

            if (!string.IsNullOrEmpty(filterTags))
            {
                result = result.Where(u => u.Tags.Contains(filterTags));
            }
            //Show Paging
            int take = 20;
            int skip = (pageId - 1) * take;
            ProductForProductListViewModel list = new ProductForProductListViewModel();
            list.CurrentPage = pageId;
            list.PageCount = result.Count() / take;
            list.Products = result.OrderBy(u => u.CreateTime).Skip(skip).Take(take).ToList();
            return list;
        }

        public int AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.ProductId;
        }

        public int CreateProductsForAdmin(CreateProductViewModel product)
        {
            Product addProduct = new Product();
            addProduct.ProductTitle = product.ProductName;
            addProduct.Price = product.ProductPrice;
            addProduct.ProductNumber = product.ProductNumber;
            addProduct.ShortDescription = product.ProductFeature;
            addProduct.Description = product.ProductDescription;
            addProduct.IsActive = true;
            addProduct.IsDelete = false;
            addProduct.Tags = product.ProductTags;
            addProduct.CreateTime = DateTime.Now;

            //Product Image
            if (product.ProductImageName != null)
            {
                string imagePath = "";
                addProduct.ProductImage = GeneratorCode.GenerateGuidCode() + Path.GetExtension(product.ProductImageName.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimg/images", addProduct.ProductImage);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    product.ProductImageName.CopyTo(stream);
                }

            }

            return AddProduct(addProduct);
        }

        public void AddGroupsToProduct(List<int> groupIds, int productId)
        {
            foreach (int groupId in groupIds)
            {
                _context.ProductSelectedGroups.Add(new ProductSelectedGroup()
                {
                    GroupId = groupId,
                    ProductId = productId
                });
            }

            _context.SaveChanges();
        }

        public List<ProductGroup> GetAllGroups()
        {
            return _context.ProductGroups.ToList();
        }

        public List<SelectListItem> GetGroupForManageProduct()
        {
            return _context.ProductGroups.Where(g => g.ParentId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageProduct(int groupId)
        {
            return _context.ProductGroups.Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }
    }
}
