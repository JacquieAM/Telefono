using System;
using System.Collections.Generic;
using System.Text;

namespace Telefono
{
    class FiltrarChinos : Celular
    {
        public FiltrarChinos(String marcaCelular, int anioCelular, Boolean esChino, Boolean seActualiza) :
           base(marcaCelular, anioCelular, esChino, seActualiza)
        {
       
        }
        //constructor vacio
        public FiltrarChinos()
        {

        }

        //determinar si el cellar es candidato a actualizacion
        public void determinarCandidato(String marcaCelular)
        {
            this.marcaCelular = marcaCelular;
            

            if( marcaCelular == "Xiaomi" || marcaCelular == "Huawei" || marcaCelular == "RealMe" || marcaCelular == "OPPO")
            {
                this.esChino = true;
            }

            if(anioCelular <= 2009 || esChino == true)
            {
                this.seActualiza = false;
                System.Console.WriteLine("Su celular no es candidato para actualizacion");
                if(esChino == true)
                {
                    System.Console.WriteLine("Debido a que es de origen Chino");
                }
            }

            if(anioCelular > 2009 && esChino == false)
            {
                System.Console.WriteLine("Su celular es candidato para actualizacion");
            }
        }
        public void determinarCandidato(int anioCelular)
        {
            
            this.anioCelular = anioCelular;

            if (anioCelular <= 2009 || esChino == true)
            {
                this.seActualiza = false;
                System.Console.WriteLine("Su celular no es candidato para actualizacion");
                if (anioCelular <= 2009)
                {
                    System.Console.WriteLine("Debido a que es del anio 2009 o anterior al 2009");
                }

            }

            if (anioCelular > 2009  && esChino == false && anioCelular < 2021)
            {
                System.Console.WriteLine("Su celular es candidato para actualizacion");
                
            }
        }

    }
    


}
