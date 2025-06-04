using EnglishProyect.view;
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
        public static List<bool> respuestas;

        public int resultados(bool data) {

           respuestas.Add(data);


            return respuestas.Count; }
    }
}
