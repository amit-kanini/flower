using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderAPI.FlowerModel;

namespace OrderAPI.Repository
{
    public class RepoClass : IOrder
    {
        public void AddingToOrderDetails(int tempFlowerId, int tempCustomerid, double tempTotalPrice, string tempRemark, string tempPaymentStatus)
        {
            //  _log4net.Info("Add to order details is invoked");
            OrderDetail temp = new OrderDetail();
            temp.FlowerId = tempFlowerId;
            temp.CustomerId = tempCustomerid;
            temp.Totalprice = tempTotalPrice;
            temp.Remark = tempRemark;
            temp.PaymentStatus = tempPaymentStatus;

            using (var db = new dbFlowerStoreContext())
            {
                db.OrderDetails.Add(temp);
                db.SaveChanges();
            }
        }

        public List<Occasion> GetAllOccasion()
        {
            using (var db = new dbFlowerStoreContext())
            {
                return db.Occasions.ToList();
            }
        }

        public List<OrderDetail> OrderdetailsbyCustomerId(int id)
        {
            List<OrderDetail> orderlist = new List<OrderDetail>();
            using (var db = new dbFlowerStoreContext())
            {
                foreach (var temp in db.OrderDetails.ToList())
                {
                    if (temp.CustomerId == id)
                    {
                        orderlist.Add(temp);
                    }
                }
                return orderlist;
            }

        }
    }
}
