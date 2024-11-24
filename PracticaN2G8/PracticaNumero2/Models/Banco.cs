using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNumero2.Models
{
    [Serializable]
    public class Banco
    {
        #region viene de afuera
        List<Persona> clientes = new List<Persona>();
        List<Cuenta> cuentas = new List<Cuenta>();
        #endregion

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
                Cuenta c = null;
                if (idx >= 0 && idx < CantidadCuentas)
                {
                    c = cuentas[idx];
                }
                return c;
            }
        }
        public Cuenta AgregarCuenta(int n,int dni,string nom)
        {
            Persona p = new Persona(dni, nom);
            Cuenta c = new Cuenta(n, p);
            cuentas.Add(c);
            return c;
        }
        public Persona VerClientePorDNI(int n)
        {
            Persona p = null;
            Persona pe = new Persona(n, null);
            clientes.Sort();
            int idx = clientes.BinarySearch(pe);
            p = clientes[idx];
            return p;
        }
        public Cuenta VerCuentaPorNumero(int numC)
        {
            Cuenta c = null;
            Cuenta cu = new Cuenta(numC, null);
            cuentas.Sort();
            int idx = cuentas.BinarySearch(cu);
            if(idx >= 0)
            {
                c = cuentas[idx];
            }
            return c;
        }
        public bool RestaurarCuenta(int numero, double saldo, DateTime fecha, Persona persona)
        {
            Persona p = VerClientePorDNI(persona.DNI);//Busca al cliente asociado al DNI en una lista de clientes.
            if (p == null)                           // Si no existe.
            {
                Persona per = new Persona(persona.DNI, persona.Nombre);//lo crea.
                clientes.Add(per);
            }
            Cuenta nueva = VerCuentaPorNumero(numero);//verifica existenia de la cuenta con el numero dado.
            if(nueva != null)//si existe
            {
                return false;//es falso que no existe
            }
            nueva = new Cuenta(numero,p,fecha,saldo);// y sino la tengo que crear debido a que no existe
            cuentas.Add(nueva);//la agrego a la lista
            return true;//es verdadero que no existe
        }
        
    }
}
