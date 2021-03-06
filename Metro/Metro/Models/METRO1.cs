﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Metro.Models;

namespace Metro.Models
{

  public class Kvart
    {
        //konstruktor

        public Kvart(string kvartIme)
        {
            KvartIme = kvartIme;

        }

        public string KvartIme { get; set; }


    }



    public class Ruta
    {

        //konstruktor 

        public Ruta(Kvart start, Kvart kraj, int duljina)
        {
            Start = start;
            Kraj = kraj;
            Duljina = duljina;

        }

        public Kvart Start { get; set; }
        public Kvart Kraj { get; set; }
        public int Duljina { get; set; }

      
    }



    public class Mapa
    {
      
        public Mapa(string imeMetroa , string izvor) 
        {
            ImeMetroa = imeMetroa;
            Izvor = izvor;
        }  

       
         public List<Ruta> KonstrukcijaRuta() {

             List<Ruta> Rute = new List<Ruta>();

            

             string[] sp = this.Izvor.Split(',');

                foreach (string dataItem in sp)
                {

                    var results = dataItem.Split('-');
                    string a = results[0];
                    string b = results[1]; 
                    var dot = b.Split(':'); 
                    string c = dot[0];
                    var d = dot[1];
                    int duljina = Int32.Parse(d);

                    Kvart kvart1 = new Kvart(a);
                    Kvart kvart2 = new Kvart(c);
                  
                  

                    Ruta temp = new Ruta(kvart1, kvart2, duljina);
                    Rute.Add(temp);
                  
                   
                }


                return Rute;



        }

     
        public string ImeMetroa { get; set;}
        public string Izvor { get; set;}
        
    }
}