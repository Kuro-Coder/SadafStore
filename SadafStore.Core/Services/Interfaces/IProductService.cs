using System;
using System.Collections.Generic;
using System.Text;
using SadafStore.DataLayer.Entities.Product;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IProductService
    {
        #region Groups

        List<ProductGroup> GetAllGroups();

        #endregion
    }
}
