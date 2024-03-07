namespace UserControlTask
{
    public partial class PersonRecordUserControl : UserControl
    {
        public event EventHandler btnUpdateClicked;
        public event EventHandler btnDeleteClicked;

        public PersonRecordUserControl()
        {
            InitializeComponent();
            btnUpdate.Click += (sender, e) =>
            {
                btnUpdateClicked?.Invoke(this, EventArgs.Empty);
            };
            btnDelete.Click += (sender, e) =>
            {
                btnDeleteClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        public string PersonID
        {
            get => TextBoxID.Text;
            set => TextBoxID.Text = value;
        }

        public string PersonName
        {
            get => TextBoxName.Text;
            set => TextBoxName.Text = value;
        }

        public string PersonSurname
        {
            get => TextBoxSurname.Text;
            set => TextBoxSurname.Text = value;
        }

        public string PersonPatronymic
        {
            get => TextBoxPatronymic.Text;
            set => TextBoxPatronymic.Text = value;
        }

        public string PersonAge
        {
            get => TextBoxAge.Text;
            set => TextBoxAge.Text = value;
        }
    }
}
