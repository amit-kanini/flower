using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowApi.FlowerModel;
using FlowApi.Provider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FlowApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(FlowController));

        // List<Flower> flower = new List<Flower>();
        public FlowController(Iprovider _ip)
        {
            ip = _ip;
           // _log4net = log4net.LogManager.GetLogger(typeof(FlowController));
        }

        Iprovider ip;
       // public FlowController(dbFlowerStoreContext db)
        //{
        //    this.db = db;
        //}

        [HttpPost]
        [Route("RegisterFlower")]
        public IActionResult RegisterFlower(Flower temp)
        {
            //_log4net.Info("Adding new flower is invoked");
            //db.Flowers.Add(temp);
            //await db.SaveChangesAsync();
            //return Ok();
            _log4net.Info("Adding new flower is invoked");
            try
            {
                ip = new Providerclass();
                ip.RegisterFlower(temp);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }

        //---------------------------------------------Get Flower by ID---------------------------------
        //[HttpGet]
        //[Route("FlowerbyId")]
        //public async Task<ActionResult<Flower>> FlowerbyId(int id)
        //{
        //    _log4net.Info("Get flower by " + id + " is invoked");
        //    Flower temp = await db.Flowers.FindAsync(id);
        //    return Ok(temp);
        //}


        [HttpGet("id")]
        public IActionResult Get(int Id)
        {
            _log4net.Info("Get flower by " + Id + " is invoked");
            try
            {
                ip = new Providerclass();
                return Ok(ip.GetFlowerById(Id));
            }
            catch
            {
                return BadRequest();
            }

        }
        //---------------------------------------------Get Flower by Name-------------------------------
        //[HttpGet]
        //[Route("FlowerbyName")]
        //public async Task<ActionResult<Flower>> FlowerbyId(string flowername)
        //{
        //    _log4net.Info("Get flower by " + flowername + " is invoked");
        //    List<Flower> flowerlist = new List<Flower>();
        //    foreach (var temp in await db.Flowers.ToListAsync())
        //    {
        //        if (temp.Name.ToLower() == flowername.ToLower())
        //        {
        //            flowerlist.Add(temp);
        //        }
        //    }
        //    return Ok(flowerlist);
        //}

        [HttpGet("name")]
        public IActionResult Get(string name)
        {
            _log4net.Info("Get flower by " + name + " is invoked");
            try
            {
                ip = new Providerclass();
                return Ok(ip.GetFlowerById(name));
            }
            catch
            {
                return BadRequest();
            }

        }
        //---------------------------------------------Get All Flower-----------------------------------
        //[HttpGet]
        //[Route("GetAllFlower")]
        //public async Task<ActionResult<Flower>> GetAllFlower()
        //{
        //    _log4net.Info(" Http Get Drug Details request");
        //    try
        //    {
        //        ip = new Providerclass();
        //        return Ok(ip.GetAllFlower());
        //    }
        //    catch
        //    {
        //        return BadRequest();
        //    }
        //}

        //---------------------------------------------Update Flower Details-----------------------------
        [HttpPut]
        [Route("UpdateFlower")]
        public  IActionResult UpdateFlower(Flower temp)
        {
            //_log4net.Info("UPdate flower is invoked");
            //db.Entry(temp).State = EntityState.Modified;
            //await db.SaveChangesAsync();
            //return Ok();
            _log4net.Info("UPdate flower is invoked");
            try
            {
                ip = new Providerclass();
                ip.UpdateFlower(temp);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        //---------------------------------------------Delete a Flower by ID----------------------------
        [HttpDelete]
        [Route("DeleteFlowerbyId")]
        public ActionResult<Flower> DeleteFlowerbyId(int id)
        {
            //_log4net.Info("Delete flower by " + id + " is invoked"); ;
            //Flower temp = await db.Flowers.FindAsync(id);
            //db.Flowers.Remove(temp);
            //await db.SaveChangesAsync();
            //return Ok();

            _log4net.Info("Delete flower by " + id + " is invoked");
            try
            {
                ip = new Providerclass();
                ip.DeleteFlowerbyId(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
