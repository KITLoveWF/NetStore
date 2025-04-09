using NetStore.Form.FormLoginAndFoget;
using NetStore.Form.FormMenu;
using NetStore.Form.FormStateComputer;
using NetStore.Form.FormCustomer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NetStore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Write("xin chào");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CustomerLoginForm());
        }
    }
}
