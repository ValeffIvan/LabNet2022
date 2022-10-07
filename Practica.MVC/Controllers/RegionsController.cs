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
    public class RegionsController : Controller
    {
        RegionLogic logic = new RegionLogic();

        // GET: Regions
        public ActionResult Index()
        {
            List<Region> region = logic.GetAll();

            List<RegionsView> regionsView = region.Select(s => new RegionsView
            {
                RegionID = s.RegionID,
                RegionDescription = s.RegionDescription,
            }).ToList();
            return View(regionsView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(RegionsView regionsView)
        {
            try
            {
                var regionEntity = new Region
                {
                    RegionID = regionsView.RegionID,
                    RegionDescription = regionsView.RegionDescription,
                };
                logic.Add(regionEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(RegionsView regionsView)
        {
            try
            {

                var regionUpdate = new Region();
                regionUpdate.RegionID = regionsView.RegionID;
                regionUpdate.RegionDescription = regionsView.RegionDescription;
                logic.Update(regionUpdate);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

    }
}