using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzariaProjeto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.IO.File.Exists(@"C:\bkp\pizzaria_restaura.bak"))
            {
                Conexao.RestauraBkp();
                string caminho = "pizzaria" + DateTime.Now.ToString();
                caminho = caminho.Replace("/", "_");
                caminho = caminho.Replace(" ", "_");
                caminho = caminho.Replace(":", "_");
                System.IO.File.Move(@"C:\bkp\pizzaria_restaura.bak", @"C:\bkp\" + caminho + ".bak");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPrincipal());

            }

            else
            {
                  Application.EnableVisualStyles();
                  Application.SetCompatibleTextRenderingDefault(false);
                  Application.Run(new frmPrincipal());
            }

          


        }
    }
}
