using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderAPI.FlowerModel;
using OrderAPI.Repository;

namespace OrderAPI.Provider
{
    public class ProviderClass : IProvider
    {
        IOrder _orderRepository;
        public ProviderClass()
        {
        }
        public void AddingToOrderDetails(int tempFlowerId, int tempCustomerid, double tempTotalPrice, string tempRemark, string tempPaymentStatus)
        {
            _orderRepository = new RepoClass();
            _orderRepository.AddingToOrderDetails(tempFlowerId, tempCustomerid, tempTotalPrice, tempRemark, tempPaymentStatus);
        }

        public List<Occasion> GetAllOccasion()
        {
            _orderRepository = new RepoClass();
            return _orderRepository.GetAllOccasion();
        }

        public List<OrderDetail> OrderdetailsbyCustomerId(int id)
        {
          _orderRepository = new RepoClass();
            return _orderRepository.OrderdetailsbyCustomerId(id);
        }
    }
}
