using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowApi.Controllers;
using FlowApi.FlowerModel;
using FlowApi.Provider;
using FlowApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace FlowApiTest
{
    [TestFixture]
    class UnitTestForController
    {
        
        Flower f = new Flower()
        {
            Id = 1,
            Name = "Rose",
            Occassion = "Birthday",
            UnitPrice = 500,
            AvailableQuantity = 10,
            FlImage = null,


        };
        //[Test]
        //public void TestFlowerByIdValid()
        //{
        //    Mock<Providerclass> mock = new Mock<Providerclass>();
        //    mock.Setup(p => p.GetFlowerById(1)).Returns(f);
        //    FlowController con = new FlowController(mock.Object);
        //    var data = con.Get(1) as OkObjectResult;
        //    Assert.AreEqual(200, data.StatusCode);
        //}



    }
}
