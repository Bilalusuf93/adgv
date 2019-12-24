using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ADGVSample
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //definir a cultura para toda a aplicação
            var ci = new CultureInfo("pt_BR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ADGVSample());
        }
    }
}
