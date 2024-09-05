using Veterinary_Clinic.Views;
using System.Configuration;
using Veterinary_Clinic._Repositories;
using Veterinary_Clinic.Presenters;

namespace Veterinary_Clinic
{
    public static class App
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = ConfigurationManager
                .ConnectionStrings["MySQL"]
                .ConnectionString;
            IMainView view = new MainView();
            _ = new MainPresenter(view, sqlConnectionString);
            Application.Run((Form) view);
        }
    }
}