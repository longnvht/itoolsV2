using itools_source.Models.Interface;
using itools_source.Presenter;
using itools_source.Repository;
using itools_source.Utils;
using itools_source.Views;
using itools_source.Views.Interface;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

//[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace itools_source
{
    internal static class Program
    {
        public static Session sessionLogin = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            CultureInfo cul = new CultureInfo("vi-VN");
            cul.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            cul.DateTimeFormat.LongDatePattern = "yyyy-MM-dd";
            cul.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            cul.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            Thread.CurrentThread.CurrentCulture = cul;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //string strConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            ILoginView view = new LoginView();
            IUserAccountRepository repository = new UserAccountRepository();
            new LoginPresenter(view, repository);

            Application.Run((Form)view);
        }
    }
}
