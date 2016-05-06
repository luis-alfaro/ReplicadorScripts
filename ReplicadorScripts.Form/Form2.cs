using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ReplicadorScripts.WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtSeparador.Text = "/*end*/";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string[] cabeceras = txtCabeceras.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string contenido = txtContenido.Text;
            string separador = txtSeparador.Text;
            
            string resultado = "";
            for (int i = 0; i < cabeceras.Length; i++)
            {
                resultado += cabeceras[i] + Environment.NewLine + contenido;
                if (i != cabeceras.Length - 1) resultado += Environment.NewLine + separador + Environment.NewLine + Environment.NewLine;
            }
            GuardarArchivo(resultado);

            MessageBox.Show("El proceso terminó exitosamente.");
        }

        private void GuardarArchivo(string contenido)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "Resultados";
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

            using (StreamWriter streamWriter = new StreamWriter(directory + @"\result.txt", false))
            {
                streamWriter.Write(contenido);
                streamWriter.Flush();
            }            
        }
    }
}
