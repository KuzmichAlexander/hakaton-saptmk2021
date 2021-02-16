using Hahatun.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hahatun.Controllers
{
    public class CertCheckerController : Controller
    {
        // GET: SertCheckerController
        public ActionResult Index()
        {
            return View();
        } 
        
        //public ActionResult Check(int certnumber, DateTime certdate, int manufacturercode, string companycode, int checkcode, string productname, int status, string certurl)
        [HttpGet]
        public ActionResult Check(CertInfoModel certInfo)
        {
            DateTime date;
            DateTime.TryParse(certInfo.certdate,out date);
            ViewBag.certnumber = certInfo.certnumber;
            ViewBag.date = date;

            return View();
        }


        //// GET: SertCheckerController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: SertCheckerController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: SertCheckerController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SertCheckerController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: SertCheckerController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SertCheckerController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: SertCheckerController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
