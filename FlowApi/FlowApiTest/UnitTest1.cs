using System.Collections.Generic;
using FlowApi.FlowerModel;
using FlowApi.Repository;
using NUnit.Framework;

namespace FlowApiTest
{
    public class Tests
    {
        Flower f = new Flower()
        {
            Id=1,
            Name="Rose",
            Occassion="Birthday",
            UnitPrice=500,
            AvailableQuantity=10,
            FlImage=null,


        };

        List<Flower> f1 = new List<Flower>();
        [SetUp]
        public void Setup()
        {
        
            f1= new List<Flower>
            {
                new Flower()
                {
                 Id=1,
            Name="Rose",
            Occassion="Birthday",
            UnitPrice=500,
            AvailableQuantity=10,
            FlImage=null,
                }
            };
        }

        [Test]

        public void TestFlowerByIdValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.GetFlowerById(1);
            Assert.AreEqual(f.Id, b.Id);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }

        [Test]

        public void TestFlowerByIdInValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.GetFlowerById(5);
            if (b == null)
            {
                b = new Flower()
                {
                    Id = 0,
                };
                
            }
            Assert.AreNotEqual(f.Id, b.Id);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }
        [Test]
        public void TestFlowersByIdValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.GetFlowerById("Rose");
            Assert.AreEqual(f1[0].Id, b[0].Id);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }
        [Test]
        public void TestFlowersByIdInValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.GetFlowerById("Lily");
            Assert.AreNotEqual(f1, b);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }

    }
}