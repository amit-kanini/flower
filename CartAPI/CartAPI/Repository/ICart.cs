using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartAPI.FlowerModel;

namespace CartAPI.Repository
{
    interface ICart
    {
        public List<Cart> CartbyCustID(int id);

        public void DeleteItemFromCart(int Customerid, int FlowerId);
        public void AdditemtoCart(int tempCustomerid, int tempFlowerid, int tempQty, double tempItemPrice);

        public void UpdateStatusInCart(int id);


    }
}
