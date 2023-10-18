using EjercicioCalculadoraAritmetica.Servicios;

namespace EjercicioCalculadoraAritmetica.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// </summary>
    /// <author>171023 - rfg</author>
    class Program
    {
        /// <summary>
        /// Método main de la aplicación, es el núcleo procedimental
        /// </summary>
        /// <author>171023 - rfg</author>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionesInterfaz oi = new OperacionesImplementacion();

            int opcionSeleccionada;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        oi.sumar();
                        break;
                    case 2:
                        oi.restar();
                        break;
                    case 3:
                        oi.multiplicar();
                        break;
                    case 4:
                        oi.dividir();
                        break;
                    default:
                        Console.WriteLine("No se ha elegido una opción correcta");
                        break;
                }
            }
        }
    }
}
