using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowApi.FlowerModel;
using FlowApi.Repository;

namespace FlowApi.Provider
{
    public class Providerclass : Iprovider
    {
        IFlower _flowerRepository;
        public Providerclass()
        {
        }

        public void DeleteFlowerbyId(int id)
        {
            _flowerRepository = new RepoClass();
            _flowerRepository.DeleteFlowerbyId(id);
        }

        public Flower GetFlowerById(int id)
        {
            _flowerRepository = new RepoClass();
            return _flowerRepository.GetFlowerById(id);
        }

        public List<Flower> GetFlowerById(string name)
        {
            _flowerRepository = new RepoClass();
            return _flowerRepository.GetFlowerById(name);
        }

        public void RegisterFlower(Flower temp)
        {
            _flowerRepository = new RepoClass();
             _flowerRepository.RegisterFlower(temp);
        }

        public void UpdateFlower(Flower temp)
        {
            _flowerRepository = new RepoClass();
             _flowerRepository.UpdateFlower(temp);
        }
    }
}
