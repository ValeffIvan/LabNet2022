using Practica.EF.Entities;
using Practica.EF.Logic.Logic;
using Practica.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Practica.WebApi.Controllers
{
    [RoutePrefix("api/Shippers")]
    public class ShippersController : ApiController
    {
        private readonly ShippersLogic shippersLogic = new ShippersLogic();

        // GET: api/Shippers
        [HttpGet]
        public List<ShippersView> Get()
        {
            var result = shippersLogic.GetAll().Select(p => new ShippersView
            {
                CompanyName = p.CompanyName,
                Phone = p.Phone,
                ShipperID = p.ShipperID,
            }).ToList();
            return result;
        }

        // GET: api/Shippers/8
        [HttpGet]
        public ShippersView Get(int id)
        {
            try
            {
                var shippers = shippersLogic.GetAll().SingleOrDefault(e => e.ShipperID.Equals(id));
                var result = new ShippersView
                {
                    ShipperID = shippers.ShipperID,
                    CompanyName = shippers.CompanyName,
                    Phone = shippers.Phone
                };
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        // POST: api/Shippers
        [HttpPost]
        public void Post(Shippers shipper)
        {
            shippersLogic.Add(shipper);
        }

        // DELETE: api/Shippers/8
        [HttpDelete]
        public void Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
            }
            catch (Exception ex)
            {
            }
        }
    }
}