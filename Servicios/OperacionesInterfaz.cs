using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCalculadoraAritmetica.Servicios
{
    /// <summary>
    /// Interfaz que declara los métodos operativos de la calculadora
    /// </summary>
    /// <author>171023 - rfg</author>
    internal interface OperacionesInterfaz
    {
        /// <summary>
        /// Solicita al usuario dos operandos y los suma
        /// </summary>
        /// <author>171023 - rfg</author>
        public void sumar();
        /// <summary>
        /// Solicita al usuario dos operandos y los resta
        /// </summary>
        /// <author>171023 - rfg</author>
        public void restar();
        /// <summary>
        /// Solicita al usuario dos operandos y los multiplica
        /// </summary>
        /// <author>171023 - rfg</author>
        public void multiplicar();
        /// <summary>
        /// Solicita al usuario dos operandos y los divide
        /// </summary>
        /// <author>171023 - rfg</author>
        public void dividir();

    }
}
