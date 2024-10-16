using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    public class Banco
    {
        
       private List<Cuenta> cuentas = new List<Cuenta>();
       private List<Persona> clientes = new List<Persona>();
        public int CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }
        public int CantidadCuentas
        {
            get
            {
                return cuentas.Count;
            }
            
        }
        public Cuenta this[int idx]
        {
            get
            {
                return cuentas[idx];
            }
        }

        #region metodos
        public Cuenta AgregarCuenta(int numC,int dni,string nom)
        {
            Cuenta c = null;
            Persona pe = VerClientePorDni(dni);
            if(pe == null)
            {
                pe = new Persona(dni, nom);
                c = new Cuenta(numC, pe);
                cuentas.Add(c);
                clientes.Add(pe);  
            }
            else
            {
                c = new Cuenta(numC, pe);
                cuentas.Add(c);
            }
            return c;
        }
        public Cuenta VerCuentaPorNumero(int numC)
        {
            Cuenta c = new Cuenta(numC, null);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(c);
            Cuenta ca = cuentas[idx];
            return ca;
        }
        public Persona VerClientePorDni(int dni)
        {
            Persona p = new Persona(dni, null);
            clientes.Sort();
            int idx = clientes.BinarySearch(p);
            Persona cli = clientes[idx];
            return cli;
        }

        public bool RestaurarCuenta(int n, double s, DateTime f, Persona t)
        {
            Cuenta cuen = VerCuentaPorNumero(n);
            if(cuen == null)
            {
                cuen = new Cuenta(n, t, f, s);
                cuentas.Add(cuen);
                return true;
            }
            else
            {
                cuentas.Add(cuen);//si ya esta, entonces la agregamos
                return true;
            }
        }
        #endregion
    }
}
