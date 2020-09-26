using System;
using System.Collections.Generic;
using System.Text;
using SadafStore.Core.DTOs.Order;
using SadafStore.DataLayer.Entities.Order;

namespace SadafStore.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int productId);

        void UpdatePriceOrder(int orderId);

        Order GetOrderForUserPanel(string userName, int orderId);

        bool FinalyOrder(string userName, int orderId);

        List<Order> GetUserOrders(string userName);

        Order GetOrderById(int orderId);

        void UpdateOrderDetail(OrderDetail detail);

        #region DisCount

        DisCountUseType UseDisCount(int orderId, string code);
        void UpdateOrder(Order order);

        #endregion

        #region Admin

        void AddDiscount(DisCount disCount);
        List<DisCount> GetAllDiscounts();
        DisCount GetDisCountById(int discountId);
        void UpdateDiscount(DisCount disCount);
        bool IsExistCode(string code);

        #endregion

        

    }
}
