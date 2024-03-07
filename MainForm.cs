namespace UserControlTask
{
    public partial class MainForm : Form
    {
        private int personId;
        private int count;
        private int sumAge;

        public MainForm()
        {
            InitializeComponent();
            personId = 0;
            count = 0;
            sumAge = 0;
        }

        public void createPersonUserControl(PersonDto dto)
        {
            PersonRecordUserControl personRecord = new PersonRecordUserControl
            {
                PersonID = Convert.ToString(++personId),
                PersonName = dto.PersonName!,
                PersonSurname = dto.PersonSurname!,
                PersonPatronymic = dto.PersonPatronymic!,
                PersonAge = Convert.ToString((int)dto.PersonAge!)
            };

            personRecord.btnUpdateClicked += btnUpdate_Click!;
            personRecord.btnDeleteClicked += btnDelete_Click!;

            PersonList.Controls.Add(personRecord);

            Calculate();
        }

        public void updatePerson(PersonDto personDto)
        {
            foreach (Control control in PersonList.Controls)
            {
                if (control is PersonRecordUserControl personRecord &&
                    personRecord.PersonID == personDto.PersonId.ToString())
                {
                    personRecord.PersonName = personDto.PersonName!;
                    personRecord.PersonSurname = personDto.PersonSurname!;
                    personRecord.PersonPatronymic = personDto.PersonPatronymic!;
                    personRecord.PersonAge = Convert.ToString((int)personDto.PersonAge!);
                    break;
                }
            }

            Calculate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PersonDto personDto = new PersonDto();
            PersonRecordEditDialog personRecordEditDialog = new PersonRecordEditDialog(this, personDto, 0);
            personRecordEditDialog.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var personRecord = sender as PersonRecordUserControl;

            PersonDto personDto = new PersonDto
            {
                PersonId = Convert.ToInt32(personRecord!.PersonID),
                PersonName = personRecord.PersonName,
                PersonSurname = personRecord.PersonSurname,
                PersonPatronymic = personRecord.PersonPatronymic,
                PersonAge = Convert.ToInt32(personRecord.PersonAge)
            };

            PersonRecordEditDialog personRecordEditDialog = new PersonRecordEditDialog(this, personDto, 1);
            personRecordEditDialog.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PersonList.Controls.Remove(sender as PersonRecordUserControl);
            Calculate();
        }

        public void Calculate()
        {
            count = 0; sumAge = 0;

            foreach (Control control in PersonList.Controls)
            {
                if (control is PersonRecordUserControl personRecord)
                {
                    count++;
                    sumAge += Convert.ToInt32(personRecord.PersonAge);
                }
            }

            TextBoxCount.Text = count.ToString();
            TextBoxAge.Text = sumAge.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
