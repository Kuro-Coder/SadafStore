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

        public int AddProduct(Product product, IFormFile imgProduct)
        {
            product.CreateTime = DateTime.Now;
            product.IsDelete = false;
             product.ProductImage = "no-photo.jpg";
            //TODO Check Image
            if (imgProduct != null)
            {
                product.ProductImage = GeneratorCode.GenerateGuidCode() + Path.GetExtension(imgProduct.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productimg/images", product.ProductImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgProduct.CopyTo(stream);
                }
            }

            //ToDO Upload Demo 

            _context.Add(product);
            _context.SaveChanges();

            return product.ProductId;
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

        public List<ShowProductForAdminViewModel> GetProductsForAdmin()
        {
            return _context.Products.Select(p => new ShowProductForAdminViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductTitle,
                ProductFeature = p.ShortDescription,
                ProductPrice = p.Price,
                ProductNumber = p.ProductNumber,
                ProductDescription = p.Description,
                ProductIsActive = p.IsActive,
                ProductImageName = p.ProductImage
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
