using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ChromeLaunch
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Main(string[] args)
        {
            // Hide the console window
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
          
            string chrome = "C:\\Program Files\\Google\\Chrome\\Application\\gchrome.exe";

            // Start the process
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = chrome;
            startInfo.Arguments = "--disable-print-preview --disable-popup-blocking --disable-smooth-scrolling --allow-no-sandbox-job --disable-gpu --disable-direct-write";
            Process.Start(startInfo);


        }
    }
}
