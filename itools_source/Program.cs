using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using itools_source.Views;
using itools_source.Views.Interface;
using itools_source.Presenter;
using itools_source.Models.Interface;
using itools_source.Models;
using itools_source.Repository;
using itools_source.Utils;
using System.Configuration;

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //string strConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            ILoginView view = new LoginView();
            IAssessorRepository repository = new AssessorRepository();
            new LoginPresenter(view, repository);

            Application.Run((Form)view);
            //Application.Run(new MainView());
        }
    }
}
