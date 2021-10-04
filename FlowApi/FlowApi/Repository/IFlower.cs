using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowApi.FlowerModel;

namespace FlowApi.Repository
{
    interface IFlower
    {

        public Flower GetFlowerById(int id);
        public List<Flower> GetFlowerById(string name);
       public void UpdateFlower(Flower temp);
       public void DeleteFlowerbyId(int id);
        public void RegisterFlower(Flower temp);




    }
}
