﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro.Models
{
    public class MyModel4
    {


        public int stops { get; set; }
        public class Pair<string, string> //stations
        {
            public Pair()
            {
            }

            public Pair(string Start, string End)
            {
                this.start= Start;
                this.end = End;
            }

            public string start { get; set; }
            public string end { get; set; }
        };


        public int PutBezCiklusa(Kvart start, List<Ruta> Rute)
        {

            for (int i = 0; i < 6; i++)
            { 
                    
            
            
            
            }


        }
    }
}