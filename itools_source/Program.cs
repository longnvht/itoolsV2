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

//[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace itools_source
{
    internal static class ConfigUnity
    {
        public static UnityContainer unityContainer { get; private set; } = new UnityContainer();
        public static void Register()
        {
            unityContainer.RegisterType<ILoginView, LoginView>();
            unityContainer.RegisterType<IUserAccountRepository, UserAccountRepository>();

            unityContainer.RegisterType<IMainView, MainView>();

            unityContainer.RegisterType<IMenuView, MenuView>();
            unityContainer.RegisterType<IMenuRepository, MenuRepository>();

            unityContainer.RegisterSingleton<IJobView, JobView>();
            unityContainer.RegisterSingleton<IJobRepository, JobRepository>();

            unityContainer.RegisterSingleton<IToolManagerView, ToolManagerView>();
            unityContainer.RegisterSingleton<IToolMachineTrayRepository, ToolMachineTrayRepository>();

            unityContainer.RegisterSingleton<IConfigSettingView, ConfigSettingView>();
            unityContainer.RegisterSingleton<ICompanyRepository, CompanyRepository>();

            unityContainer.RegisterSingleton<IOPView, OPView>();
            unityContainer.RegisterSingleton<IGetToolRepository, GetToolRepository>();

            unityContainer.RegisterSingleton<IGetToolView, GetToolView>();

            unityContainer.RegisterSingleton<IStockView, StockView>();
            unityContainer.RegisterSingleton<IStockRepository, StockRepository>();
        }
    }

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

            ConfigUnity.Register();
            var loginPresenter = ConfigUnity.unityContainer.Resolve<LoginPresenter>();
            loginPresenter.Run();
        }
    }
}
