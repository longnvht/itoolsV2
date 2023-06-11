using itools_source.Models.Interface;
using VinamiToolUser.Presenter;
using itools_source.Repository;
using VinamiToolUser.Utils;
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

namespace VinamiToolUser
{
    internal static class UnityDI
    {
        public static UnityContainer container { get; private set; } = new UnityContainer();
        public static void Register()
        {
            container.RegisterType<ILoginView, LoginView>();
            container.RegisterType<ILoginRepository, LoginRepository>();
            container.RegisterType<IMainView, MainView>();
            container.RegisterType<IMainRepository, MainRepository>();
            container.RegisterType<IMenuView, MenuView>();
            container.RegisterType<IMenuRepository, MenuRepository>();
            container.RegisterType<IJobView, JobView>();
            container.RegisterType<IJobRepository, JobRepository>();
            container.RegisterType<ISettingView, SettingView>();
            container.RegisterType<ISettingRepository, SettingRepository>();
            container.RegisterType<IOPViewNew, OpView>();
            container.RegisterType<IOpRepository, OpRepository>();
            container.RegisterType<IGetToolRepository, GetToolRepository>();
            container.RegisterType<IGetToolView, GetToolView>();
            container.RegisterType<IManageToolView, ManageToolView>();
            container.RegisterType<IManageToolRepository, ManageToolRepository>();
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
            MainView mainView = MainView.GetInstance();
            //mainViewNew.Show();
            Application.Run(mainView);
        }
    }
}
