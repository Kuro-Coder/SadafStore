using System;
using System.Collections.Generic;
using System.Text;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int productId);

    }
}
