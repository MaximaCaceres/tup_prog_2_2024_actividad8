using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNumero2.Models
{
    [Serializable]
    public class Persona:IComparable,IExportable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int d, string n)
        {
            DNI = d;
            Nombre = n;
        }
        public int CompareTo(object obj)//para ver cliente por dni
        {
            Persona p = obj as Persona;
            if (p != null)
            {
             return DNI.CompareTo(p.DNI);
            }
            return 1;    
        }
        public override string ToString()
        {
            string dat = $"{DNI};{Nombre}";
            return dat;
        }
        public string Escribir()//escribo los datos de esta clase con el ToString().
        {
            return ToString();
        }
        public void Leer(string n)//leo para rellenar los datos de esta clase.
        {
            string[] dat;
            dat = n.Split(';');//separo los datos

            //DNI;Nombre; //Número de cuenta;Saldo

            DNI = Convert.ToInt32(dat[0]);//ahora los ubico segun su posicion.
            Nombre = dat[1];//aqui lo mismo.
        } 
    }
}
