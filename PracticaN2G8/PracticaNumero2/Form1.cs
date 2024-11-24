using PracticaNumero2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaNumero2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Banco ban = new Banco();
        string path = Application.StartupPath + "banco.dat";
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    ban = bf.Deserialize(fs) as Banco;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null) { fs.Close(); }
                }
            }
            if (ban != null)
            {

                ban.AgregarCuenta(45548214, 2343243, "Jauck, Ramón");
                ban.AgregarCuenta(29566454, 3343243, "Jauck, Andrés");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs = null;
            Cuenta c = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs,ban);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Im = new OpenFileDialog();
            Im.Filter = "Ficheros csv|*.csv";
            if (Im.ShowDialog() == DialogResult.OK)
            {
                string ruta = Im.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                Cuenta c = null;
                try
                {
                    fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea = sr.ReadLine();
                    while(sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        c.Leer(linea);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(sr != null)sr.Close();
                    if(fs != null)fs.Close();
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog Ex = new SaveFileDialog();
            Ex.Filter = "Ficheros csv|*.csv";
            if (Ex.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                string ruta = Ex.FileName;
                Cuenta c = null;
                try
                {
                    fs = new FileStream(ruta,FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("DNI;nombre;número de cuenta;saldo");
                    for(int i = 0; i <ban.CantidadCuentas; i++)
                    {
                        c = ban[i];
                        sw.WriteLine($"{c.Escribir()}");//este tiene todo los datos.
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show (ex.Message);
                }
                finally
                {
                    if(sw!=null)sw.Close();
                    if(fs!=null)fs.Close();
                }
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Cuenta c = null;
            for (int i = 0; i < ban.CantidadCuentas; i++)//recorro hasta la cantidad de cuentas.
            {
                c = ban[i];//tomo cada una
                tbxListar.Text += c.ToString();//ahora las paso al textBox.
            }
        }
    }
}
