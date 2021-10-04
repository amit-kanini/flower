using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowApi.FlowerModel;
using Microsoft.EntityFrameworkCore;

namespace FlowApi.Repository
{
    public class RepoClass : IFlower
    {
        public RepoClass()
        {
        }
        public readonly dbFlowerStoreContext db;
        public Flower GetFlowerById(int id)
        {
            //Flower flower = new Flower()
            //{
            //    Id = id,
            //    Name = "Rose",
            //    Occassion="Birthday",
            //    UnitPrice=500,
            //    FlImage=null,
            //};
            using(var db=new dbFlowerStoreContext())
            {
                Flower flower = db.Flowers.Find(id);
                return flower;
            }
            
            
        }

        public List<Flower> GetFlowerById(string name)
        {
            List<Flower> flowerlist = new List<Flower>();
            using (var db = new dbFlowerStoreContext())
            {
                foreach (var temp in  db.Flowers.ToList())
                {
                    if (temp.Name.ToLower() == name.ToLower())
                    {
                        flowerlist.Add(temp);
                    }
                }
            }
            return flowerlist;

        }

        public void UpdateFlower(Flower temp)
        {
            using (var db = new dbFlowerStoreContext())
            {
                db.Entry(temp).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteFlowerbyId(int id)
        {
            using (var db = new dbFlowerStoreContext()) {
                Flower temp =  db.Flowers.Find(id);
                db.Flowers.Remove(temp);
                 db.SaveChanges();
            }
                
        }

        public void RegisterFlower(Flower temp)
        {
            using (var db = new dbFlowerStoreContext())
            {
                db.Flowers.Add(temp);
                db.SaveChanges();
            }
        }
    }
}
