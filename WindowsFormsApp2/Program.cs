using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace TestTask
{
    static class Program
    {
        private static string connectionString = @"Data Source=ольга-пк;Initial Catalog=TutorialDB;Integrated Security=True";

        public static DataContext Database { get; private set; }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database = new DataContext(connectionString);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

