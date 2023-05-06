using App.Business.Abstract;
using App.DataAccess.Abstract;
using App.DataAccess.Concrete.EFEntityFramework;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {
            
        private IOrderDetailDal _orderDetail;

        public OrderDetailService(IOrderDetailDal orderDetail)
        {
            _orderDetail = orderDetail;
        }



        public void Add(OrderDetail orderdetail)
        {
            _orderDetail.Add(orderdetail);
        }

        public void Delete(int id)
        {
            var item = _orderDetail.Get(p => p.OrderId == id);
            _orderDetail.Delete(item);
        }

        public void DeleteProductID(int ProductId1)
        {
            var item = _orderDetail.GetList(o => o.Product.ProductId==ProductId1);
            foreach (var item1 in item)
            {
                _orderDetail.Delete(item1);
            }
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetail.GetList();
        }
    }
}
