using System;
using System.Windows.Forms;

namespace PostSap_GR_TR
{
    class Program
    {
        [STAThread]


        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new BBL_test());
            Application.Exit();
        }
    }
}
