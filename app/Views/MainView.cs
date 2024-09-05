namespace Veterinary_Clinic.Views
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler ShowPetView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVetsView;

        public MainView()
        {
            InitializeComponent();
            buttonPets.Click += (s,e) => ShowPetView?.Invoke(this, EventArgs.Empty);
        }
    }
}
