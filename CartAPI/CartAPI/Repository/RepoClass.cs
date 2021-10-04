using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartAPI.FlowerModel;
using Microsoft.EntityFrameworkCore;

namespace CartAPI.Repository
{
    public class RepoClass : ICart
    {
        public void AdditemtoCart(int tempCustomerid, int tempFlowerid, int tempQty, double tempItemPrice)
        {
            Cart temp = new Cart();
            temp.CustomerId = tempCustomerid;
            temp.FlowerId = tempFlowerid;
            temp.Quantity = tempQty;
            temp.ItemPrice = tempItemPrice;
            using (var db = new dbFlowerStoreContext()) { 
            db.Carts.Add(temp);
            db.SaveChangesAsync();
        }
            
        }

        public List<Cart> CartbyCustID(int id)
        {
            List<Cart> Cartlist = new List<Cart>();
            using (var db = new dbFlowerStoreContext())
            {
                foreach (var temp in db.Carts.ToList())
                {
                    if (temp.CustomerId == id)//&& temp.Status.Equals("Pending"))
                    {
                        Cartlist.Add(temp);
                    }
                }
                return Cartlist;
            }
        }

        public void DeleteItemFromCart(int Customerid, int FlowerId)
        {
            using (var db = new dbFlowerStoreContext())
            {
                Cart temp = db.Carts.Find(Customerid,FlowerId);
                db.Carts.Remove(temp);
                db.SaveChanges();
            }
        }

        public void UpdateStatusInCart(int id)

        { using (var db = new dbFlowerStoreContext())
            {
                Cart temp = db.Carts.Find(id);
                //temp.status = "placed";
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
                
            }



        }
    }
}
