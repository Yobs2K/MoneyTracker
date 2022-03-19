using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileHandler fh = new FileHandler();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(fh));
        }
    }

    public static class Misc
    {
        public static string get_DOW_drom_date(string DT_DOW_S)
        {
            string DOW;
            switch (DT_DOW_S)
            {
                case "Monday":
                    DOW = "Ïí";
                    break;
                case "Tuesday":
                    DOW = "Âò";
                    break;
                case "Wednesday":
                    DOW = "Ñð";
                    break;
                case "Thursday":
                    DOW = "×ò";
                    break;
                case "Friday":
                    DOW = "Ïò";
                    break;
                case "Saturday":
                    DOW = "Ñá";
                    break;
                case "Sunday":
                    DOW = "Âñ";
                    break;
                default:
                    DOW = "";
                    break;
            }
            return DOW;
        }
    }
}
