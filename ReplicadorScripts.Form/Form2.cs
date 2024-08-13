using System;
using System.IO;
using System.Windows.Forms;

namespace ReplicadorScripts.WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtSeparador.Text = "GO";
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
            //comentario1
            string[] cabeceras = txtCabeceras.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string contenido = txtContenido.Text;
            string textoSeparador = txtSeparador.Text;
            string separador = string.IsNullOrEmpty(textoSeparador) ? string.Empty : (Environment.NewLine + textoSeparador);

            string resultado = "";
            for (int i = 0; i < cabeceras.Length; i++)
            {
                resultado += cabeceras[i] + separador + Environment.NewLine + contenido + separador;
                if (i != cabeceras.Length - 1) resultado += Environment.NewLine + Environment.NewLine;
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
