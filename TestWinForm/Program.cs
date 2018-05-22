using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Service.Implements;
using Service.Interfaces;
using SimpleInjector;

namespace TestWinForm
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<Form1>());
        }
        private static void Bootstrap()
        {
            container = new Container();

            container.Register<IService<Address>, ServiceFor<Address>>();

            container.Register<Form1>();

        }
    }
}
