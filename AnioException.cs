using System;
using System.Collections.Generic;
using System.Text;

namespace Telefono
{
    class AnioFuturoException : ApplicationException
    {
        public  AnioFuturoException(): base("Aplicaste un anio fuera de rango, ya que aun no salen modelos de ese anio a futuro")
        {

        }

        public AnioFuturoException(string mensaje) : base (mensaje)
        {

        }

        public AnioFuturoException(string mensaje, Exception anidada)
            : base(mensaje, anidada)
        {

        }
    }
}
