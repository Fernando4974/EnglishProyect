using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishProyect.controller
{
    internal class CalculoPuntuacion : CapturaDeRespuestas
    {
        static int ptsTrip = 0;
        static int ptsBonus = 0;
        static int ptsTotal = 0;
        static int ptsExamen = 0;

        public void setPtsTrip(int pts) {
            ptsTrip=pts;
                }
        public void setPtsBonus(int pts)
        {
            ptsBonus = pts;
        }
        public void setPtsTotal(int pts)
        {
            ptsTotal = pts;
        }
        public void setPtsExamen(int pts)
        {
            ptsExamen = pts;
        }

        public CalculoPuntuacion() { }


        public int CalcularTotal(int _ptsTrip,  int _ptsExamen, int _ptsBonus) 
        {

            ptsTotal= _ptsTrip+_ptsExamen+_ptsBonus;


            return ptsTotal;
        }
    
    
        public int CalcularBonus() {


            for (int i = 0; i < respuestasBonus.Count; i++)
            {
                if (respuestasBonus[i] == true )
                {
                    ptsBonus++;
                }
            }

            return ptsBonus;

        }


        public int CalcularTrip()
        { 


            for (int i = 0; i <= 12; i++)
            {                
               
                    if (respuestas[i] == true)
                    {
                        ptsTrip++;
                    }
                 
              

            }

            return ptsTrip;

        }
        public int CalcularExamen()
        {


            for (int i = 13; i < respuestas.Count; i++)
            {

                if (respuestas[i] == true)
                {
                    ptsExamen++;
                }



            }

            return ptsExamen;

        }

    }
}
