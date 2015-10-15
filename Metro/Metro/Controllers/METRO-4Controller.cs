﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Metro.Models;

namespace Metro.Controllers
{
    public class METRO_4Controller : Controller
    {
        //
        // GET: /METRO-4/

        public ActionResult metro4()
        {
            return View();
        }

        //
        // GET: /METRO-4/Details/5

        public JsonResult metro4Post(MyModel4 request)
        {
            string ulaznaDatoteka = (string)TempData["Metro"];
            // Mapa metro = new Mapa("ZagrebMetro", ulaznaDatoteka);


            List<Ruta> Lista = new List<Ruta>()
            { 

                new Ruta(new Kvart("MAKSIMIR"), new Kvart("SIGET"),5), 
                new Ruta(new Kvart("SIGET"),new Kvart("SPANSKO"),4), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("MEDVESCAK"),8),
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("SPANSKO"), 8), 
                new Ruta(new Kvart("MEDVESCAK"),new Kvart("DUBRAVA"),6), 
                new Ruta(new Kvart("MAKSIMIR"), new Kvart("MEDVESCAK"),5), 
                new Ruta(new Kvart("SPANSKO"),new Kvart("DUBRAVA"), 2), 
                new Ruta(new Kvart("DUBRAVA"),new Kvart("SIGET"),3), 
                new Ruta(new Kvart("MAKSIMIR"),new Kvart("DUBRAVA"),7) 
            };

            //List<Ruta> Lista = metro.KonstrukcijaRuta();
            List<Ruta> r = new List<Ruta>();
            foreach (Ruta ru in Lista)
            { r.Add(ru); }

             MyModel5 model = new MyModel5() { count = 0, stops = new string[] { "" } };
             MyModel5 model2 = new MyModel5() { count = 0 };
          
            //Kvart start = new Kvart(request.stations.start);

           // model2.PutBezCiklusa( start, Lista);

            //return View("zagrebPost");

            return Json(model2, JsonRequestBehavior.AllowGet);




        }

    }
}
