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
            txtCabeceras.Text =
                "USE BelcorpBolivia" + Environment.NewLine +
                "USE BelcorpChile" + Environment.NewLine +
                "USE BelcorpColombia" + Environment.NewLine +
                "USE BelcorpCostaRica" + Environment.NewLine +
                "USE BelcorpDominicana" + Environment.NewLine +
                "USE BelcorpEcuador" + Environment.NewLine +
                "USE BelcorpGuatemala" + Environment.NewLine +
                "USE BelcorpMexico" + Environment.NewLine +
                "USE BelcorpPanama" + Environment.NewLine +
                "USE BelcorpPeru" + Environment.NewLine +
                "USE BelcorpPuertoRico" + Environment.NewLine +
                "USE BelcorpSalvador";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
//comentario2
            string[] cabeceras = txtCabeceras.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string contenido = txtContenido.Text;
            string separador = txtSeparador.Text;
            
            string resultado = "";
            for (int i = 0; i < cabeceras.Length; i++)
            {
                resultado += cabeceras[i] + Environment.NewLine + contenido;
                if (i != cabeceras.Length - 1)
                {
                    if (!string.IsNullOrEmpty(separador)) resultado += Environment.NewLine + separador;
                    resultado += Environment.NewLine + Environment.NewLine;
                }
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
