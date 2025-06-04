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
        static List<bool> respuestas = new List<bool>();

        public int resultados(bool data) {

            respuestas.Add(data);


            return respuestas.Count; 
        }
        public string mostrarR()
        {
            string r ="";
            foreach (var item in respuestas)
            {
                r += item.ToString();
            }
            return r;
        }
    }
}
    

