using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopIndicators;
//<<<<<<< HEAD
using Connection;
//=======
using ConnectionMaria;
//>>>>>>> b5d070ecba66bd63fff6f2926b82ec99ac503113


 namespace TopIndicators
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}

