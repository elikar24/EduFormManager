using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace EduFormManager
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new mainForm());
            
            //SingleInstanceApplication.Run(new mainForm(), NewInstanceHandler);
        }

        static void NewInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            e.BringToForeground = true;

            if (e.CommandLine.Count == 1)
            {
                MessageBox.Show(SingleInstanceApplication.Form, "0 arguments");
            }
            else if (e.CommandLine[1].StartsWith("stat://"))
            {
                String protocolArg = String.Join(" ", e.CommandLine.Where<String>((x, i) => i > 0));
                MessageBox.Show(SingleInstanceApplication.Form, protocolArg);
            }
        }

        public class SingleInstanceApplication : WindowsFormsApplicationBase
        {
            public static Form Form {get;set;}
            private SingleInstanceApplication(){
                base.IsSingleInstance = true;
            }

            public static void Run(Form f, StartupNextInstanceEventHandler startupHandler)
            {
                DevExpress.UserSkins.BonusSkins.Register();

                Form = f;
                SingleInstanceApplication app = new SingleInstanceApplication();
                app.MainForm = f;
                app.StartupNextInstance += startupHandler;
                string[] args = Environment.GetCommandLineArgs();
                app.Run(args);
            }
        }   

    }
}
