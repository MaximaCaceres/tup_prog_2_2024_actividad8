using Actividad8.Models;
using System;
using System.IO;
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
            SantanDer.AgregarCuenta(008, 45755453, "Maxima");//este tiene dos cuentas.
            SantanDer.AgregarCuenta(009, 45755450, "Man");
            SantanDer.AgregarCuenta(010, 45755456, "MimamaMeMima");
            SantanDer.AgregarCuenta(011, 46788765, "Fernando");

            for (int i = 0; i < SantanDer.CantidadCuentas; i++)
            {
                Cuenta c = SantanDer[i];//hago uso del indexador.
                tbxLista.Text += c.ToString();
            }

        }

        private void btnImportarCuenta_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Importación de cuentas";
            openFileDialog.Filter = "fichero csv|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;//obtenemos la ruta del archivo seleccionado.

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    #region aca leemos
                    string linea = sr.ReadLine();//leemos la primera linea.
                    while (sr.EndOfStream == false)//mientras no estemos al final del archivo.
                    {
                        linea = sr.ReadLine();//leemos y guardamos en linea.

                        //parseamos
                        string[] campos = linea.Split(';');

                        int dni = Convert.ToInt32(campos[0].Trim());//en cada campo vamos a separar por ";"
                        string nombre = campos[1].Trim();
                        int numC = Convert.ToInt32(campos[2].Trim());
                        double saldo = Convert.ToDouble(campos[3].Trim());

                        Cuenta cuenta = SantanDer.AgregarCuenta(numC, dni, nombre);
                        cuenta.Saldo = saldo;//setteamos el saldo.  
                    }
                    #endregion
                }
                catch (Exception ex)//general
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();//cierro 
                    fs.Close();
                }
            }
        }

        private void btnExportarCuenta_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Exportacion de cuentas";//establecemos el titulo del cuadro de dialogo del archivo
            save.Filter = "fichero csv|*.csv";//determinamos los archivos a mostrar
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;//guardamos la ruta del archivo
                FileStream fs = null;
                StreamWriter sw = null;

                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);//flujo de escritura

                    #region escritura del archivo
                    string linea = $"DNI; nombre; número de cuenta; saldo";
                    sw.WriteLine(linea);

                    for (int idx = 0; idx < SantanDer.CantidadCuentas; idx++)
                    {
                        Cuenta cuenta = SantanDer[idx];//hacemos uso del indexador.

                        if (cuenta.Saldo >= 10000)
                        {
                            linea = $"{cuenta.Titular.DNI};{cuenta.Titular.Nombre};{cuenta.Numero};{cuenta.Saldo:f2}";
                            sw.WriteLine(linea);//escribimos solo los que son igual o superior al saldo indicado.
                        }
                    }

                    #endregion
                }
                catch (Exception ex)//excepcion general.
                {
                    MessageBox.Show(ex.Message, "Error al importar la cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                    //jose.delete();
                    //estaca.delete();
                    

                }
            }
        }
    }
}
