using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    public class Cuenta:IComparable
    {
        public Persona Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public DateTime Fecha { get; set; }

        #region metodos
        public Cuenta(int num, Persona per)
        {
     
            Titular = per;
            Numero = num;
        }
        public Cuenta(int num,Persona titu,DateTime f, double s)
        {
            Numero = num;
            Titular = titu;
            Fecha = f;
            Saldo = s;
        }
        public int CompareTo(object obj)
        {
            Cuenta c = obj as Cuenta;
            if(c != null)
            {
                return Numero.CompareTo(c.Numero);
            }
            return 1;
        }
        public override string ToString()
        {
            string date = $"{Numero}   {Titular.Nombre}   {Saldo}\n\r\n\r";
            return date;
        }
        #endregion
    }
}
