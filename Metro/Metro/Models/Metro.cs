﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class Metro
    {
        // Metro je sastavljen od liste Kvartova i liste Ruta

        public Metro(IList<Kvart> kvartovi, IList<Ruta> rute, string imeGrafa)
        {
            Kvartovi = kvartovi;
            Rute = rute;
            ImeGrafa = imeGrafa;

        }

        public IList<Kvart> Kvartovi;
        public IList<Ruta> Rute;
        public string ImeGrafa;

    
    }
}