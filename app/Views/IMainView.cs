namespace Veterinary_Clinic.Views
{
    public interface IMainView
    {
        event EventHandler ShowPetView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowVetsView;
    }
}
