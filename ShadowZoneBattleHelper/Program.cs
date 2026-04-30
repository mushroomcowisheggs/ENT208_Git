using ShadowZoneHelper.Forms;
using System;
using System.Windows.Forms;

namespace ShadowZoneHelper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}