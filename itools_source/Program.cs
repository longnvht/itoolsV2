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
using Unity;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Repository;
using VinamiToolUser.Views;
using VinamiToolUser.Views.Interface;

//[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace itools_source
{
    internal static class UnityDI
    {
        public static UnityContainer container { get; private set; } = new UnityContainer();
        public static void Register()
        {
            container.RegisterType<ILoginView, LoginView>();
            container.RegisterType<IUserAccountRepository, UserAccountRepository>();

            container.RegisterType<IMainView, MainView>();
            container.RegisterType<IMainViewNew, MainViewNew>();

            container.RegisterType<IMenuView, MenuView>();
            container.RegisterType<IMenuRepository, MenuRepository>();

            container.RegisterType<IMenuViewNew, MenuViewNew>();
            container.RegisterType<IMenuRepositoryNew, MenuRepositoryNew>();

            container.RegisterType<IJobView, JobView>();
            container.RegisterType<IJobRepository, JobRepository>();

            container.RegisterType<IJobViewNew, JobViewNew>();
            container.RegisterType<IJobRepositoryNew, JobRepositoryNew>();

            container.RegisterType<IToolManagerView, ToolManagerView>();
            container.RegisterType<IToolMachineTrayRepository, ToolMachineTrayRepository>();

            container.RegisterType<IConfigSettingView, ConfigSettingView>();
            container.RegisterType<ICompanyRepository, CompanyRepository>();

            container.RegisterType<IOPView, OPView>();

            container.RegisterType<IOPViewNew, OpViewNew>();
            container.RegisterType<IOpRepositoryNew, OpRepositoryNew>();

            container.RegisterType<IGetToolRepository, GetToolRepository>();
            container.RegisterType<IGetToolRepositoryNew, GetToolRepositoryNew>();

            container.RegisterType<IGetToolView, GetToolView>();
            container.RegisterType<IGetToolViewNew, GetToolViewNew>();

            container.RegisterType<IStockView, StockView>();
            container.RegisterType<IStockRepository, StockRepository>();
        }
    }

    internal static class Program
    {
        public static Session sessionLogin = null;

        /// <summary>
        /// The main entry point for the application.
        /// Update 27/04
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

            UnityDI.Register();
            var loginPresenter = UnityDI.container.Resolve<LoginPresenter>();
            loginPresenter.Run();
            //Application.Run(new GetToolViewNew());
        }
    }
}
