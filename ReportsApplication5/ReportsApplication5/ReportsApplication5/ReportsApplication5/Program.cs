using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsApplication5
{
	public static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 2)
            {
                //MessageBox.Show(args[0].ToString());
                int UUTID;
                if (Int32.TryParse(args[0].ToString(), out UUTID))
                { 
                    if ( (args[1] == "P") 
                        || (args[1] == "F") )
                    {
                        Application.Run(new Form1(UUTID, args[1].ToString()));
                    }
                    
                }
                else
                {
                    MessageBox.Show("Falsche Argumente übergeben: .exe [UUTID] [P||F]");
                    Application.Exit();
                }
            }
            else if (args.Length > 1)
            {
                MessageBox.Show("Falsche Argumente übergeben: .exe [UUTID] [P||F]");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Falsche Argumente übergeben: .exe [UUTID] [P||F]");
                Application.Exit();
            }
                 
                     
		}           
	}
}