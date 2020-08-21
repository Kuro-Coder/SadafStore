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

        //public int AddProduct(Product product, IFormFile imgProduct)
        //{
        //    product.CreateTime = DateTime.Now;
        //    product.IsDelete = false;
        //     product.ProductImage = "no-photo.jpg";
        //    //TODO Check Image
        //    if (imgProduct != null)
        //    {
        //        product.ProductImage = GeneratorCode.GenerateGuidCode() + Path.GetExtension(imgProduct.FileName);
        //        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimg/images", product.ProductImage);

        //        using (var stream = new FileStream(imagePath, FileMode.Create))
        //        {
        //            imgProduct.CopyTo(stream);
        //        }
        //    }

        //    _context.Add(product);
        //    _context.SaveChanges();

        //    return product.ProductId;
        //}
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
            //TODO Check Image
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
