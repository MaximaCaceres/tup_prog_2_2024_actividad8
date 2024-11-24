using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNumero2.Models
{
    [Serializable]
    public class Cuenta:IComparable, IExportable
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public DateTime Fecha { get; set; }
        public Persona Titular { get; set; }

        public Cuenta(int n,Persona p)
        {
            Numero = n;
            Titular = p;
        }
        public Cuenta(int n, Persona p, DateTime d, double s)
        {
            Numero = n;
            Titular= p;
            Fecha = d;
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
            string dat = $"{Titular.Escribir()};{Numero};{Saldo:f2}";
            return dat;
        }
        public string Escribir()
        {
            string linea = $"{ToString()}";
            return linea;
        }
        public void Leer(string n)
        {
            string[] dat;
            dat = n.Split(';');//separo los datos para que leo para rellenar la clase.

            //DNI;Nombre; //Número de cuenta;Saldo

            Numero = Convert.ToInt32(dat[2]);//almacenamos los datos de "dat" en donde corresponde.
            Saldo = Convert.ToDouble(dat[3]);
        }
    }
}
