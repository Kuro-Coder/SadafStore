using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SadafStore.Core.DTOs.Order;
using SadafStore.Core.Services.Interfaces;
using SadafStore.DataLayer.Context;
using SadafStore.DataLayer.Entities.Order;
using SadafStore.DataLayer.Entities.User;
using SadafStore.DataLayer.Entities.Wallet;

namespace SadafStore.Core.Services
{
    public class OrderService : IOrderService
    {
        private SadafStoreContext _context;
        private IUserService _userService;

        public OrderService(SadafStoreContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public int AddOrder(string userName, int productId)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            Order order = _context.Orders.FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);
            

            var product = _context.Products.Find(productId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateTime = DateTime.Now,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            ProductId = productId,
                            Count = 1,
                            Price = product.Price
                        }
                    },
                    OrderSum = product.Price 
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails
                    .FirstOrDefault(d => d.OrderId == order.OrderId && d.ProductId == productId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        ProductId = productId,
                        Price = product.Price,
                    };
                    _context.OrderDetails.Add(detail);
                }

                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }

            return order.OrderId;
        }

        public bool FinalyOrder(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            var order = _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.OrderId == orderId && o.UserId == userId);

            if (order == null || order.IsFinaly)
            {
                return false;
            }

            if (_userService.BalanceUserWallet(userName) >= order.OrderSum)
            {
                order.IsFinaly = true;
                _userService.AddWallet(new Wallet()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتور شماره #" + order.OrderId,
                    UserId = userId,
                    TypeId = 2
                });
                _context.Orders.Update(order);

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Order> GetUserOrders(string userName)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            return _context.Orders.Include(o => o.OrderDetails)
                .Where(o => o.UserId == userId).ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public Order GetOrderForUserPanel(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            return _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Product)
                .FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price * d.Count);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public DisCountUseType UseDisCount(int orderId, string code)
        {
            var disCount = _context.DisCounts.SingleOrDefault(d => d.DisCountCode == code);

            #region check Types

            if (disCount == null)
                return DisCountUseType.NotFound;

            if (disCount.StartDate != null && disCount.StartDate < DateTime.Now)
                return DisCountUseType.ExpireDate;

            if (disCount.EndDate != null && disCount.EndDate >= DateTime.Now)
                return DisCountUseType.ExpireDate;

            if (disCount.UsableCount != null && disCount.UsableCount <1)
                return DisCountUseType.Finished;

            var order = GetOrderById(orderId);

            if (_context.UserDiscountCodes.Any(d => d.UserId == order.UserId && d.DiscountId == disCount.DiscountId))
                return DisCountUseType.UsedDiscount;

            #endregion

            int percent = (order.OrderSum * disCount.DisCountPercent) / 100;
            order.OrderSum = order.OrderSum - percent;

            UpdateOrder(order);
            if (disCount.UsableCount!=null)
            {
                disCount.UsableCount -= 1;
            }

            _context.DisCounts.Update(disCount);
            _context.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = disCount.DiscountId
            });
            _context.SaveChanges();

            return DisCountUseType.Success;

        }

        public void UpdateOrderDetail(OrderDetail detail)
        {
            _context.OrderDetails.Update(detail);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
    }
}
