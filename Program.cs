using System;
using System.Windows.Forms;

namespace MovieAPI // Certifique-se de que o namespace seja o mesmo de Form1.cs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Form1 agora está no mesmo namespace
        }
    }
}
