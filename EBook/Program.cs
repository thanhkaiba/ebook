using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBook
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
            //FormStart form = new FormStart();
            Novel novel = new Novel();
            novel.id = 1;
            novel.chapters = new List<Chapter>();
            FormRead form = new FormRead(novel);
            form.Show();
            Application.Run();
        }
    }
}
