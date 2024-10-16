using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    public class Persona:IComparable
    {
       public int DNI { get; set; }
        public string Nombre { get; set; }
        #region metodos
        public Persona(int d, string n)
        {
            DNI = d;
            Nombre = n;
        }

        public int CompareTo(object obj)
        {
            Persona p = obj as Persona;
            if(p != null)
            {
                return DNI.CompareTo(p.DNI);
            }
            return 1;
        }
        #endregion
    }
}
