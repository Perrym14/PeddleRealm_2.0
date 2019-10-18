using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeddleRealmCore.Models;

namespace PeddleRealmCore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
