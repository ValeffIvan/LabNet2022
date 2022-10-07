using Practica.EF.Entities;
using Practica.EF.Logic.Logic;
using Practica.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {

            List<Shippers> shippers = logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();
            return View(shippersView);
        }


        public ActionResult Insert ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert (ShippersView shippersView)
        {
            try
            {
                var shipperEntity = new Shippers
                {
                    ShipperID = shippersView.ShipperID,
                    CompanyName = shippersView.CompanyName,
                    Phone = shippersView.Phone
                };
                logic.Add(shipperEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index","Error");
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(ShippersView shippersView)
        {
            try
            {

                var shippersUpdate = new Shippers();
                shippersUpdate.ShipperID = shippersView.ShipperID;
                shippersUpdate.CompanyName = shippersView.CompanyName;
                shippersUpdate.Phone = shippersView.Phone;
                logic.Update(shippersUpdate);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}