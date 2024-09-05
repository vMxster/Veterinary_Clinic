namespace Veterinary_Clinic.Views
{
    public partial class PetView : Form, IPetView
    {
        private static PetView? instance;
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
            buttonAdd.Click += (s, e) =>
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add new Pet";
            };
            buttonEdit.Click += (s, e) =>
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Edit Pet";
            };
            buttonSave.Click += (s, e) =>
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            buttonCancel.Click += (s, e) =>
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);
            };
            buttonDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected pet?",
                    "Warning!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }

        public static PetView GetInstance(Form parentContainer)
        {
            if (instance is null || instance.IsDisposed)
            {
                instance = new PetView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}