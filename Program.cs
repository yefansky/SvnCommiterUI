using SharpSvn;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvnCommiterUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMain());
        }

        public static Collection<string> GetSvnChangedUri(string path)
        {
            var client = new SvnClient();
            var statuses = new Collection<SvnStatusEventArgs>();
            Collection<string> result = new Collection<string>();

            try
            {
                bool bRetCode = client.GetStatus(path, out statuses);
                if (bRetCode)
                {
                    foreach (var item in statuses)
                    {
                        if (item.Uri != null)
                            result.Add(item.Uri.ToString());
                    }
                }
            } 
            catch (Exception)
            {

            }
            return result;
        }
    }
}
