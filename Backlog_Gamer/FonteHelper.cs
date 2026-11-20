using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Backlog_Gamer
{
    public static class FonteHelper
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static bool carregada = false;

        public static Font ObterFonte(float tamanho, FontStyle estilo = FontStyle.Regular)
        {
            if (!carregada)
            {

                byte[] fontData = Properties.Resources.PressStart2P;
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                pfc.AddMemoryFont(fontPtr, fontData.Length);
                Marshal.FreeCoTaskMem(fontPtr);
                carregada = true;
            }

            return new Font(pfc.Families[0], tamanho, estilo);
        }

        public static void AplicarNoForm(Control container, float tamanho = 8f)
        {
            Font fonte = ObterFonte(tamanho);

            foreach (Control controle in container.Controls)
            {
                controle.Font = fonte;

                if (controle is Panel || controle is GroupBox)
                {
                    AplicarNoForm(controle, tamanho);
                }
            }
        }
    }
}