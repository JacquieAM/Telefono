using System;

namespace Telefono
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            FiltrarChinos telefono = new FiltrarChinos();

            Console.WriteLine("\nMenu");
            int mainAnioCelular = 0;
            try
            {
                Console.WriteLine("\nIngrese el anio de su celular");
                mainAnioCelular = Convert.ToInt32(Console.ReadLine());
                telefono.determinarCandidato(mainAnioCelular);
            }
            catch(FormatException)
            {
                System.Console.WriteLine("El dato que escribiste no es un numero");
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("El dato no se ha inicializado");
            }
            finally
            
            {
                if (mainAnioCelular >2021)


                    throw new AnioFuturoException();
            }

            try
            {
                Console.WriteLine("\nIngrese la marca de su celular");
                String mainMarcaCelular = Console.ReadLine();
                telefono.determinarCandidato(mainMarcaCelular);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("El dato que escribiste no corresponde al formato");
            }
            catch (NullReferenceException)
            {
                System.Console.WriteLine("El dato no se ha inicializado");
            }
            catch (OverflowException)
            {
                System.Console.WriteLine("El dato no puede guardar el valor");
            }
            


        }
    }
}
