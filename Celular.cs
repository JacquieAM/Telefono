using System;
using System.Collections.Generic;
using System.Text;

namespace Telefono
{
    class Celular
    {
        //declaracion de variables

        protected String marcaCelular;
        protected int anioCelular;
        protected Boolean esChino;
        protected Boolean seActualiza;

        //constructor
        public Celular(String marcaCelular, int anioCelular, Boolean esChino, Boolean seActualiza)
        {
            this.marcaCelular = marcaCelular;
            this.anioCelular = anioCelular;
            this.esChino = esChino;
            this.seActualiza = seActualiza;
        }

        //constructor vacio
        public Celular()
        {

        }

        public void info()
        {
            System.Console.WriteLine("\n Marca del Celular: " + marcaCelular);
            System.Console.WriteLine("\n Anio del Celular: " + anioCelular);
            System.Console.WriteLine("\n El celular es chino? : " + esChino);
            System.Console.WriteLine("\n El celular se actualiza? : " + seActualiza);
        }

        //get setters
        public String MarcaCelular
        {
            get { return this.marcaCelular; }
            set { this.marcaCelular = marcaCelular; }
        }

        public int AnioCelular
        {
            get { return this.anioCelular; }
            set { this.anioCelular = anioCelular; }
        }

        public Boolean EsChino
        {
            get { return this.esChino; }
            set { this.marcaCelular = marcaCelular; }
        }

        public Boolean SeActualiza
        {
            get { return this.seActualiza; }
            set { this.seActualiza = seActualiza; }
        }
    }
}
