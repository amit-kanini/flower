using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerAPI.FlowerModel;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Repository
{
    public class RepoClass : ICustomer
    {
        public Customer CustomerbyId(int id)
        {
            using (var db = new dbFlowerStoreContext())
            {
                Customer temp =  db.Customers.Find(id);
                return temp;
            }

        }

        public Customer CustomerLogin(string tempPhone, string tempPass, string tempType)
        {
            Customer cus = new Customer();
            using (var db = new dbFlowerStoreContext())
            {
                foreach (var temp in  db.Customers.ToList())
                {
                    //changed
                    if (temp.Phone == tempPhone && temp.Password == tempPass && temp.Vendor == tempType)
                    {
                        //changed
                         cus = temp;
                        
                    }
                }
                return cus;
            }
           
        }

        public void DeleteCustomerbyId(int id)
        {
            using (var db = new dbFlowerStoreContext())
            {
                Customer temp =  db.Customers.Find(id);
                db.Customers.Remove(temp);
                 db.SaveChanges();
            }
        }

        public void RegisterCustomer(Customer temp)
        {
            using (var db = new dbFlowerStoreContext())
            {
                db.Customers.Add(temp);
                db.SaveChangesAsync();
            }
        }

        public void UpdateCustomer(Customer temp)
        {
            using (var db = new dbFlowerStoreContext())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChangesAsync();
            }
        }
    }
}
