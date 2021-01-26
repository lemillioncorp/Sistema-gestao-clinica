using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Clinica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //==================INICIA A APLICAÇÂO
            operacao.Iniciar();

            //Apresenta o Forma de Inicialização o SPAN
            Application.Run(new span());
        }
    }
}
