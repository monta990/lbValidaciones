using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace libValidaciones
{
    public class libValidaciones
    {
        /// <summary>
        /// Valida nombres personales, tanto los nombre aislados
        /// los apellidos, como valida tambien nombre y apellido
        /// separada por espacios
        /// </summary>
        /// <param name="nom">Nombre a validar</param>
        /// <returns>Regresa True si el strig nom es un nombre propio o False si no cumpre con ser nombre propio</returns>
        public static bool NombrePersonal(string nom)
        {
            Regex regEx = new Regex(@"^[A-ZÁÉÍÓÚÑ][ÑñáéíóúÁÉÍÓÚ\sa-zA-Z]+[a-záéíóúA-ZÁÉÍÓÚ]$");
            return regEx.IsMatch(nom);
        }
        /// <summary>
        /// Este metodo de clase vvalida el RFC 13 carcteres
        /// 4 letras, AAMMDD y Homoclave
        /// </summary>
        /// <param name="rfcAvalidar">RFC a validar</param>
        /// <returns>True si cumple con el modelo de RFC o False si no cumple</returns>
        public static bool RFC(string rfcAvalidar)
        {
            Regex regEx = new Regex(@"([A-ZÑ&]{3,4}) ?(?:- ?)?(\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])) ?(?:- ?)?([A-Z\d]{2})([A\d])$");
            return regEx.IsMatch(rfcAvalidar);
        }
        /// <summary>
        /// Este metodo valida la curp de 16 carateres
        /// </summary>
        /// <param name="curpValidar">Curp a validar</param>
        /// <returns>True si es valida o False si no</returns>
        public static bool CURP(string curpValidar)
        {
            Regex regEx = new Regex(@"^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$");
            return regEx.IsMatch(curpValidar);
        }
        /// <summary>
        /// Este metodo valida que el codigo postal sera de 5 digitos numericos
        /// </summary>
        /// <param name="cpValidar">Codigo postal a validar</param>
        /// <returns>True si es valido o False si no</returns>
        public static bool CodigoPostal(string cpValidar)
        {
            Regex regEx = new Regex(@"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$");
            return regEx.IsMatch(cpValidar);
        }
        /// <summary>
        /// Este metodo valida si es email con la expresion regurlar
        /// </summary>
        /// <param name="emailValidar">Email a validar</param>
        /// <returns>True si es valido o False si no</returns>
        public static bool Email(string emailValidar)
        {
            Regex regEx = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return regEx.IsMatch(emailValidar);
        }
        /// <summary>
        /// Valida si lo ingresado es numero telefonico
        /// </summary>
        /// <param name="celularValidar">Telefono a validar</param>
        /// <returns>True si es valido o False si no</returns>
        public static bool Telefono(string telefonoValidar)
        {
            Regex regEx = new Regex(@"^[+-]?\d+(\.\d+)?$");
            return regEx.IsMatch(telefonoValidar);
        }
        /// <summary>
        /// Verifica si es un domicilio valido
        /// </summary>
        /// <param name="direccionValidar">Domicilio a validar</param>
        /// <returns>True si es valido o False si no</returns>
        public static bool Direccion(string direccionValidar)
        {
            //Regex regEx = new Regex(@"^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$");
            Regex regEx = new Regex(@"^[A-ZÁÉÍÓÚÑ][ÑñáéíóúÁÉÍÓÚ\sa-zA-Z]+[a-záéíóúA-ZÁÉÍÓÚ]$");
            return regEx.IsMatch(direccionValidar);
        }
        /// <summary>
        /// Valida si es un numero de INE
        /// </summary>
        /// <param name="ineValidar">INE a validar</param>
        /// <returns>True si es valido o False si no</returns>
        public static bool INE(string ineValidar)
        {
            Regex regEx = new Regex(@"^.*(?=.{13})[+-]?\d+(\.\d+)?$");
            return regEx.IsMatch(ineValidar);
        }
        /// <summary>
        /// Valida si son numeros
        /// </summary>
        /// <param name="numerosValidar">Numeros a validar</param>
        /// <returns>True si es valido o False si no</returns>
        public static bool Numeros(string numerosValidar)
        {
            Regex regEx = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            return regEx.IsMatch(numerosValidar);
        }
    }
}