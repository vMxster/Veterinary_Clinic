using Veterinary_Clinic._Repositories;
using Veterinary_Clinic.Views;

namespace Veterinary_Clinic.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView view = PetView.GetInstance((MainView) mainView);
            IPetRepository repository = new PetRepository(sqlConnectionString);
            _ = new PetPresenter(view, repository);
        }
    }
}
