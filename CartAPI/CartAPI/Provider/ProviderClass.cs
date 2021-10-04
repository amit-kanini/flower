using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartAPI.FlowerModel;
using CartAPI.Repository;

namespace CartAPI.Provider
{
    public class ProviderClass : IProvider

    {

        ICart _cartRepository;
        public ProviderClass()
        {
        }
        public void AdditemtoCart(int tempCustomerid, int tempFlowerid, int tempQty, double tempItemPrice)
        {
            _cartRepository = new RepoClass();
             _cartRepository.AdditemtoCart( tempCustomerid,tempFlowerid, tempQty, tempItemPrice);
        }

        public List<Cart> CartbyCustID(int id)
        {
            _cartRepository = new RepoClass();
            return _cartRepository.CartbyCustID(id);
        }

        public void DeleteItemFromCart(int Customerid, int FlowerId)
        {
            _cartRepository = new RepoClass();
             _cartRepository.DeleteItemFromCart(Customerid,FlowerId);
        }

        public void UpdateStatusInCart(int id)
        {
            _cartRepository = new RepoClass();
            _cartRepository.UpdateStatusInCart(id);
        }
    }
}
