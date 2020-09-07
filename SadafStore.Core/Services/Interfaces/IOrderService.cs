using System;
using System.Collections.Generic;
using System.Text;
using SadafStore.DataLayer.Entities.Order;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int productId);
        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string userName, int userId);
    }
}
