using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace JWord
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process thisProcess = Process.GetCurrentProcess();
            Process[] getAllProcess = Process.GetProcessesByName(thisProcess.ProcessName);
            if (getAllProcess.Length > 1)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Chương trình này thực sự đang chạy. Bạn  hãy kiểm tra lại biểu tượng trên thanh taskbar.", 
                    "Jword thông báo (thong bao)", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainForm());
                      
            //Application.SetSuspendState(PowerState.Hibernate,false, false);
            
        }
    }
}