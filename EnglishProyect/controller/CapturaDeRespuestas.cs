﻿using EnglishProyect.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishProyect.controller
{
    internal class CapturaDeRespuestas
    {
        //public bool[] respuestas = new bool[24];
       public static List<bool> respuestas = new List<bool>();
        
        public  static List<bool> respuestasBonus = new List<bool>();

        public void VaciarListas()
        {
            respuestas.Clear();
            respuestasBonus.Clear();
        }
        public int resultadosBonus(bool data ) {

            respuestasBonus.Add(data);

        return respuestasBonus.Count;
        }
        public int resultados(bool data) {

            respuestas.Add(data);


            return respuestas.Count; 
        }
        public string mostrarR()
        {
            string r ="";
            foreach (var item in respuestas)
            {
                r += item.ToString()+", ";
            }
            return r;
        }
        public string mostrarBonus()
        {
            string r = "";
            foreach (var item in respuestasBonus)
            {
                r += item.ToString() + ",";
            }
            return r;
        }
    }
}
    

