using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFotografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            ofdArchivo.Title = "Abrir archivo de imagen";
            ofdArchivo.Filter = "Archivo de mapa de bits|*.bmp|Archivo jpeg|*.jpg";
            ofdArchivo.FileName = "";
            respuesta = ofdArchivo.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                pbColor.Image = Image.FromFile(ofdArchivo.FileName);
            }
        }

        private void imagenBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap imagen = new Bitmap(pbColor.Image);
            Bitmap imagenGris = new Bitmap(imagen);

            for(int y= 0;y<imagen.Height;y++)
            {
                for(int x= 0;x<imagen.Width;x++)
                {
                    Color pixel = imagen.GetPixel(x, y);
                    Byte pixelGris = (Byte)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);

                    imagenGris.SetPixel(x, y, Color.FromArgb(255, pixelGris, pixelGris, pixelGris));
                }
            }
            pbGris.Image = imagenGris;
        }

        private void imagenBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap imagen = new Bitmap(pbColor.Image);
            Bitmap imagenBinaria = new Bitmap(imagen);

            for (int y = 0; y < imagen.Height; y++)
            {
                for (int x = 0; x < imagen.Width; x++)
                {
                    Color pixel = imagen.GetPixel(x, y);
                    if(pixel.R <= 128&&pixel.G<=128&&pixel.B<=128)
                    {
                        imagenBinaria.SetPixel(x, y, Color.FromArgb(255,0,0,0));
                    }
                    else
                    {
                        imagenBinaria.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                    }
                }
            }
            pbBinario.Image = imagenBinaria;
        }
    }
}
