namespace Veterinary_Clinic.Views
{
    public partial class PetView : Form, IPetView
    {
        public string PetId
        {
            get => textPetId.Text;
            set => textPetId.Text = value;
        }

        public string PetName
        {
            get => textPetName.Text;
            set => textPetName.Text = value;
        }

        public string PetType
        {
            get => textPetType.Text;
            set => textPetType.Text = value;
        }

        public string PetColour
        {
            get => textPetColour.Text;
            set => textPetColour.Text = value;
        }

        public string SearchValue
        {
            get => textSearch.Text;
            set => textSearch.Text = value;
        }

        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            InitializeUI();
        }

        private void InitializeUI()
        {
            tabControl1.TabPages.Remove(tabPagePetDetail);
            buttonClose.Click += (s, e) => this.Close();
        }

        private void AssociateAndRaiseViewEvents()
        {
            buttonSearch.Click += (s, e) => SearchEvent?.Invoke(this, EventArgs.Empty);
            textSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add other event associations here if needed
        }

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }
    }
}