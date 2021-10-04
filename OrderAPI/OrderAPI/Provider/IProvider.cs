using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderAPI.FlowerModel;

namespace OrderAPI.Provider
{
   public  interface IProvider
    {
        public void AddingToOrderDetails(int tempFlowerId, int tempCustomerid, double tempTotalPrice, string tempRemark, string tempPaymentStatus);
        public List<OrderDetail> OrderdetailsbyCustomerId(int id);
        public List<Occasion> GetAllOccasion();
    }
}
