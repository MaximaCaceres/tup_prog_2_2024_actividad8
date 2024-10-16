using Actividad8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Banco SantanDer = new Banco();
        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            SantanDer.AgregarCuenta(007, 45755453, "Maxima");
            SantanDer.AgregarCuenta(008, 45755451, "Maxi");
            SantanDer.AgregarCuenta(009, 45755450, "Man");
            SantanDer.AgregarCuenta(010, 45755456, "MimamaMeMima");
        }
    }
}
