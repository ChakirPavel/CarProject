using CarProject.Services;
using System;
using System.Windows.Forms;

namespace CarProject
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
            Application.SetCompatibleTextRenderingDefault(false);

            #region Init defoult settings app

            DataBaseService.GetInstanse(true).SetNewDataBaseType(new DataBaseSQL());

            #endregion

            Application.Run(new ListCarsView());
        }
    }
}
