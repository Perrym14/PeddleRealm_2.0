using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetUserOrders(int userId);
    }
}
