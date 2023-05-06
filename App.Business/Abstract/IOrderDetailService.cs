using App.Entities.Concrete;
using App.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Abstract
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        void Add(OrderDetail orderdetail);
        void Delete(int id);

        void DeleteProductID(int ProductId);

    }
}
