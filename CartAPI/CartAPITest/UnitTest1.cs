using System.Collections.Generic;
using CartAPI.FlowerModel;
using CartAPI.Repository;

using NUnit.Framework;

namespace FlowApiTest
{
    public class Tests
    {
        List<Cart> f= new List<Cart>();
      
        [SetUp]
        public void Setup()
        {
            f = new List<Cart>
            {
                new Cart()
                {
                 CartId=201,
                 CustomerId=101,
                 FlowerId=1,
                 Quantity=3,
                 ItemPrice=1000,

                }
            };

        }

        [Test]

        public void TestCartByIdValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.CartbyCustID(101);
            Assert.AreEqual(f[0].CartId, b[0].CartId);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }

        [Test]

        public void TestCartByIdInValid()
        {
            //int a = 1;
            RepoClass r = new RepoClass();
            var b = r.CartbyCustID(5);
            Assert.AreNotEqual(f, b);
            // Assert.AreEqual(d.Drug_Name, b.Drug_Name);
        }
     
      
    }
}