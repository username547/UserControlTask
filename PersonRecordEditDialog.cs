namespace UserControlTask
{
    public partial class PersonRecordEditDialog : Form
    {
        public MainForm mainForm;
        public PersonDto dto;
        public int mode;

        public PersonRecordEditDialog(MainForm mainForm, PersonDto dto, int mode)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.dto = dto;
            this.mode = mode;
        }

        private void PersonRecordEditDialog_Load(object sender, EventArgs e)
        {
            TextBoxID.Text = Convert.ToString(dto.PersonId);
            TextBoxName.Text = Convert.ToString(dto.PersonName);
            TextBoxSurname.Text = Convert.ToString(dto.PersonSurname);
            TextBoxPatronymic.Text = Convert.ToString(dto.PersonPatronymic);
            TextBoxAge.Text = Convert.ToString(dto.PersonAge);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateData())
            {
                clear();
                MessageBox.Show("Ошибка!");
                return;
            }

            if (mode == 0) mainForm.createPersonUserControl(dto);
            else mainForm.updatePerson(dto);
            navigateToMainForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            navigateToMainForm();
        }

        private bool validateData()
        {
            getData();
            return (dto.PersonName != "" &&
                dto.PersonSurname != "" &&
                dto.PersonPatronymic != "" &&
                dto.PersonAge != null);
        }

        private void getData()
        {
            try
            {
                dto.PersonName = TextBoxName.Text;
                dto.PersonSurname = TextBoxSurname.Text;
                dto.PersonPatronymic = TextBoxPatronymic.Text;
                dto.PersonAge = Convert.ToInt32(TextBoxAge.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            foreach (Control control in Controls)
                if (control is TextBox)
                    control.Text = "";
        }

        private void navigateToMainForm()
        {
            mainForm.Show();
            this.Close();
        }


    }
}
